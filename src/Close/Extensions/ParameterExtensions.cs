using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Close.Interfaces;
using Close.Models.Common;

namespace Close.Extensions;

public static class ParameterExtensions
{
    internal static List<KeyValuePair<string, object>> FlattenParamsValue(this object value, string keyPrefix)
    {
        List<KeyValuePair<string, object>> flatParams;

        switch (value)
        {
            case null:
                flatParams = SingleParam(keyPrefix, string.Empty);
                break;

            case IRequestOptions options:
                flatParams = FlattenParamsOptions(options, keyPrefix);
                break;

            case IDictionary dictionary:
                flatParams = FlattenParamsDictionary(dictionary, keyPrefix);
                break;

            case string s:
                flatParams = SingleParam(keyPrefix, s);
                break;

            case Stream s:
                flatParams = SingleParam(keyPrefix, s);
                break;

            case IEnumerable enumerable:
                flatParams = FlattenParamsList(enumerable, keyPrefix);
                break;

            case DateTime dateTime:
                flatParams = SingleParam(keyPrefix, ((DateTimeOffset)dateTime).ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture));
                break;

            case Enum e:
                flatParams = SingleParam(keyPrefix, JsonSerializer.Serialize(e).Trim('"'));
                break;

            default:
                flatParams = SingleParam(keyPrefix, string.Format(CultureInfo.InvariantCulture, "{0}", value));
                break;
        }

        return flatParams;
    }

    internal static List<KeyValuePair<string, object>> FlattenParamsOptions(IRequestOptions options, string keyPrefix)
    {
        var flatParams = new List<KeyValuePair<string, object>>();
        if (options == null)
            return flatParams;

        foreach (var property in options.GetType().GetRuntimeProperties())
        {
            var attribute = property.GetCustomAttribute<JsonPropertyNameAttribute>();
            if (attribute == null)
                continue;

            var value = property.GetValue(options, null);
            if (value == null)
                continue;

            var key = attribute.Name;
            var newPrefix = NewPrefix(key, keyPrefix);

            flatParams.AddRange(FlattenParamsValue(value, newPrefix));
        }

        return flatParams;
    }
    
    internal static List<KeyValuePair<string, object>> FlattenParamsDictionary(IDictionary dictionary, string keyPrefix)
    {
        var flatParams = new List<KeyValuePair<string, object>>();
        if (dictionary == null)
        {
            return flatParams;
        }

        foreach (DictionaryEntry entry in dictionary)
        {
            var key = string.Format(CultureInfo.InvariantCulture, "{0}", entry.Key);
            var value = entry.Value;

            var newPrefix = NewPrefix(key, keyPrefix);

            flatParams.AddRange(FlattenParamsValue(value, newPrefix));
        }

        return flatParams;
    }

    internal static List<KeyValuePair<string, object>> FlattenParamsList(IEnumerable list, string keyPrefix)
    {
        var flatParams = new List<KeyValuePair<string, object>>();
        if (list == null)
        {
            return flatParams;
        }

        var index = 0;
        foreach (var value in list)
        {
            var newPrefix = $"{keyPrefix}[{index}]";
            flatParams.AddRange(FlattenParamsValue(value, newPrefix));
            index += 1;
        }

        if (!flatParams.Any())
        {
            flatParams.Add(new KeyValuePair<string, object>(keyPrefix, string.Empty));
        }

        return flatParams;
    }

    internal static List<KeyValuePair<string, object>> SingleParam(string key, object value)
    {
        var flatParams = new List<KeyValuePair<string, object>>();
        flatParams.Add(new KeyValuePair<string, object>(key, value));
        return flatParams;
    }

    internal static string NewPrefix(string key, string keyPrefix)
    {
        if (string.IsNullOrEmpty(keyPrefix))
        {
            return key;
        }

        var i = key.IndexOf("[", StringComparison.Ordinal);
        if (i == -1)
        {
            return $"{keyPrefix}[{key}]";
        }
        else
        {
            return $"{keyPrefix}[{key.Substring(0, i)}]{key.Substring(i)}";
        }
    }
}