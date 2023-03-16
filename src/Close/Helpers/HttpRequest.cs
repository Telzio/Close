using System.Net.Http.Json;
using Close.Models.Common;

namespace Close.Helpers;

public class HttpRequest<TEntityReturned> where TEntityReturned : ICloseEntity
{
    private readonly CloseClient _closeClient;
    private readonly string _endpoint;

    public HttpRequest(CloseClient closeClient, string endpoint)
    {
        _closeClient = closeClient;
        _endpoint = endpoint;
    }

    public async Task<TEntityReturned> ExecuteAsync(HttpMethod method, string entityId = null, CancellationToken cancellationToken = default)
    {
        var httpRequestMessage = new HttpRequestMessage()
        {
            Method = method,
            RequestUri = BuildUri(entityId),
        };

        var apiResponse = await _closeClient._httpClient.SendAsync(httpRequestMessage, cancellationToken);
        await apiResponse.HandleErrorResponseAsync();
        
        var responseEntity = await apiResponse.Content.ReadFromJsonAsync<TEntityReturned>();
        return responseEntity;
    }
    
    
    
    
    
    
    
    private Uri BuildUri(string entityId)
    {
        var uri = new UriBuilder($"{_closeClient._httpClient.BaseAddress}/{_endpoint}/");
        
        if (!string.IsNullOrEmpty(entityId))
            uri.Path += $"{entityId}/";
        
        // var query = HttpUtility.ParseQueryString(uri.Query);
        // query["page[number]"] = page.ToString();
        // query["page[size]"] = pageSize.ToString();
        // if (filters != null)
        // {
        //     foreach (var filter in filters)
        //     {
        //         query[$"filter[{filter.Key}]"] = filter.Value;
        //     }
        // }
        //
        // if (includes != null)
        // {
        //     query["include"] = string.Join(",", includes);
        // }
        //uri.Query = query?.ToString() ?? "";

        return uri.Uri;
    }
}