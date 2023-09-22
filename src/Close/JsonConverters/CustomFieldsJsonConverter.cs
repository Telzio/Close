using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;
using Close.Extensions;
using Close.Models.Common;

namespace Close.JsonConverters;

public class CustomFieldsJsonConverter : JsonConverter<CustomFields>
{
    public override bool CanConvert(Type objectType)
    {
        return (objectType == typeof(CustomFields));
    }

    public override CustomFields Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException();

        var result = new CustomFields();

        // var hej = reader.Read().FlattenParamsValue("custom");
        //
        // while (reader.Read())
        // {
        //     if (reader.TokenType == JsonTokenType.EndObject)
        //         return result;
        //
        //     // Get the key.
        //     if (reader.TokenType != JsonTokenType.PropertyName)
        //         throw new JsonException();
        //
        //     var propertyName = reader.GetString();
        //
        //     reader.Read();
        //     var value = reader.Read();
        //
        //     // Add to dictionary.
        //     result.Add(propertyName!, value.FlattenParamsValue("custom"));
        // }

        return result;
    }

    public override void Write(Utf8JsonWriter writer, CustomFields value, JsonSerializerOptions options)
    {
        writer.WriteNullValue();
        
        var keyValuePairs = value.FlattenParamsValue("custom");
        
        foreach (var keyValuePair in keyValuePairs)
        {
            switch (keyValuePair.Value)
            {
                case string s:
                    writer.WriteString(keyValuePair.Key, s);
                    break;
                case int i:
                    writer.WriteNumber(keyValuePair.Key, i);
                    break;
                case long i:
                    writer.WriteNumber(keyValuePair.Key, i);
                    break;
                case decimal i:
                    writer.WriteNumber(keyValuePair.Key, i);
                    break;
                case double i:
                    writer.WriteNumber(keyValuePair.Key, i);
                    break;
                case bool b:
                    writer.WriteBoolean(keyValuePair.Key, b);
                    break;
                case DateTime d:
                    writer.WriteString(keyValuePair.Key, d.ToString("O"));
                    break;
                case DateTimeOffset d:
                    writer.WriteString(keyValuePair.Key, d.ToString("O"));
                    break;
                case TimeSpan d:
                    writer.WriteString(keyValuePair.Key, d.ToString("hh:mm:ss"));
                    break;
                case IEnumerable enumerable:
                    writer.WriteStartArray();
                    foreach (var item in enumerable)
                    {
                        writer.WriteString(keyValuePair.Key, item.ToString());
                    }
                    writer.WriteEndArray();
                    break;
                default:
                    writer.WriteString(keyValuePair.Key, keyValuePair.Value.ToString());
                    break;
            }
            
            
        }
    }
}