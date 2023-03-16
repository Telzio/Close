using System.Net.Http.Json;
using Close.Extensions;
using Close.Helpers;
using Close.Models.Common;

namespace Close.Services;

public abstract class Service<TResult> where TResult : ICloseEntity
{
    private readonly HttpClient _httpClient;
    private readonly string _endpoint;

    public Service(CloseClient closeClient, string endpoint)
    {
        _httpClient = closeClient._httpClient;
        _endpoint = endpoint;
    }
    
    public virtual async Task<TResult> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        return await RequestAsync<TResult>(_httpClient.InstanceUrl(_endpoint, id), HttpMethod.Get, null, cancellationToken);
    }
    
    public virtual async Task<CloseList<TResult>> ListAsync(ListRequestOptions requestOptions = null, CancellationToken cancellationToken = default)
    {
        return await RequestAsync<CloseList<TResult>>(_httpClient.ClassUrl(_endpoint), HttpMethod.Get, requestOptions, cancellationToken);
    }

    public virtual async Task<T> RequestAsync<T>(Uri requestUri, HttpMethod method, IRequestOptions requestOptions, CancellationToken cancellationToken = default)
    {
        if (method != HttpMethod.Post && requestOptions != null)
        {
            requestUri = requestUri.AddQueryParameters(requestOptions);
        }
        
        var httpRequestMessage = new HttpRequestMessage()
        {
            RequestUri = requestUri,
            Method = method
        };
        
        var response = await _httpClient.SendAsync(httpRequestMessage, cancellationToken);
        await response.HandleErrorResponseAsync();
        
        return await response.Content.ReadFromJsonAsync<T>();
    }
}