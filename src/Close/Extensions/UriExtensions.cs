using System.Web;
using Close.Models.Common;

namespace Close.Extensions;

public static class UriExtensions
{
    internal static Uri AddQueryParameters(this Uri uri, IRequestOptions requestOptions)
    {
        var builder = new UriBuilder(uri);
        var query = HttpUtility.ParseQueryString(uri.Query);

        var queryParameters = requestOptions.FlattenParamsValue(null)
            .Where(kvp => kvp.Value is string)
            .Select(kvp => new KeyValuePair<string, string>(kvp.Key, kvp.Value as string))
            .ToList();

        if (queryParameters.Any())
        {
            foreach (var queryParameter in queryParameters)
            {
                query[queryParameter.Key] = queryParameter.Value;    
            }
            
            builder.Query = query.ToString() ?? "";
        }
        
        return builder.Uri;
    }

    internal static Uri ClassUrl(this HttpClient httpClient, string endpoint)
    {
        var builder = new UriBuilder(httpClient.BaseAddress!);
        builder.Path += $"{endpoint}/";

        return builder.Uri;
    }

    internal static Uri InstanceUrl(this HttpClient httpClient, string endpoint, string id)
    {
        if (string.IsNullOrEmpty(id))
            throw new ArgumentException("The resource ID cannot be null or empty.", nameof(id));

        var builder = new UriBuilder(httpClient.ClassUrl(endpoint));
        builder.Path += $"{id}/";
        
        return builder.Uri;
    }
}