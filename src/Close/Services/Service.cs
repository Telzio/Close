using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Close.Extensions;
using Close.Helpers;
using Close.Models.Common;
using Close.Models.Leads;

namespace Close.Services;

public abstract class Service
{
    // private readonly string _endpoint;
    // private readonly HttpClient _httpClient;
    
    protected Request<Lead> _request;
    
    public Service(CloseClient closeClient, string endpoint)
    {
        _request = new Request<Lead>(closeClient, endpoint);
        
        // _endpoint = endpoint;
        // _httpClient = closeClient._httpClient;
    }


    // protected virtual async Task<TEntity> GetEntityAsync<TEntity>(string id, CancellationToken cancellationToken) where TEntity : ICloseEntity
    // {
    //     var request = new HttpRequestMessage()
    //     {
    //         RequestUri = _httpClient.InstanceUrl(_endpoint, id),
    //         Method = HttpMethod.Get,
    //     };
    //
    //     return await RequestAsync<TEntity>(request, cancellationToken);
    // }
    //
    // protected virtual async Task<CloseList<TEntity>> ListEntitiesAsync<TEntity, TRequestOptions>(TRequestOptions requestOptions, CancellationToken cancellationToken) where TEntity : ICloseEntity where TRequestOptions : IRequestOptions
    // {
    //     var uri = _httpClient.ClassUrl(_endpoint);
    //     
    //     if (requestOptions != null)
    //         uri = uri.AddQueryParameters(requestOptions);
    //     
    //     var request = new HttpRequestMessage()
    //     {
    //         RequestUri = uri,
    //         Method = HttpMethod.Get,
    //     };
    //
    //     return await RequestAsync<CloseList<TEntity>>(request, cancellationToken);
    // }
    //
    // protected virtual async Task<TEntity> CreateEntityAsync<TEntity, TCreateOptions>(TCreateOptions createOptions, CancellationToken cancellationToken) where TEntity : ICloseEntity where TCreateOptions : ICreateOptions
    // {
    //     var content = JsonContent.Create(createOptions, options: _jsonSerializerOptions);
    //     await content.LoadIntoBufferAsync();
    //     
    //     var request = new HttpRequestMessage()
    //     {
    //         RequestUri = _httpClient.ClassUrl(_endpoint),
    //         Method = HttpMethod.Post,
    //         Content = content,
    //     };
    //     
    //     return await RequestAsync<TEntity>(request, cancellationToken);
    // }
    //
    // protected virtual async Task DeleteEntityAsync(string id, CancellationToken cancellationToken)
    // {
    //     var request = new HttpRequestMessage()
    //     {
    //         RequestUri = _httpClient.InstanceUrl(_endpoint, id),
    //         Method = HttpMethod.Delete,
    //     };
    //     
    //     var response = await _httpClient.SendAsync(request, cancellationToken);
    //     await response.HandleErrorResponseAsync();
    // }
    //
    //
    //
    // private async Task<T> RequestAsync<T>(HttpRequestMessage request, CancellationToken cancellationToken) 
    // {
    //     var response = await _httpClient.SendAsync(request, cancellationToken);
    //     await response.HandleErrorResponseAsync();
    //
    //     var contentString = await response.Content.ReadAsStringAsync();
    //     
    //     return await response.Content.ReadFromJsonAsync<T>(_jsonSerializerOptions);
    // }
    //
    // private static JsonSerializerOptions _jsonSerializerOptions = new()
    // {
    //     Converters = { new JsonStringEnumConverter() },
    //     DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
    // };
}