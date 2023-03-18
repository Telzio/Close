using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Close.Extensions;
using Close.Helpers;
using Close.Models.Common;
using Close.Services.Interfaces;

namespace Close.Services;

public class Request<TEntity> where TEntity : ICloseEntity
{
    private readonly string _endpoint;
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonSerializerOptions = new()
    {
        Converters = { new JsonStringEnumConverter() },
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
    };
    
    public Request(CloseClient closeClient, string endpoint)
    {
        _endpoint = endpoint;
        _httpClient = closeClient._httpClient;    
    }
    
    internal async Task<TEntity> GetEntityAsync(string id, CancellationToken cancellationToken) 
    {
        var request = new HttpRequestMessage()
        {
            RequestUri = _httpClient.InstanceUrl(_endpoint, id),
            Method = HttpMethod.Get,
        };

        return await SendAsync<TEntity>(request, cancellationToken);
    }

    internal async Task<CloseList<TEntity>> ListEntitiesAsync<TRequestOptions>(TRequestOptions requestOptions, CancellationToken cancellationToken) where TRequestOptions : IRequestOptions
    {
        var uri = _httpClient.ClassUrl(_endpoint);
        
        if (requestOptions != null)
            uri = uri.AddQueryParameters(requestOptions);
        
        var request = new HttpRequestMessage()
        {
            RequestUri = uri,
            Method = HttpMethod.Get,
        };

        return await SendAsync<CloseList<TEntity>>(request, cancellationToken);
    }
    
    internal async Task<TEntity> CreateEntityAsync<TCreateOptions>(TCreateOptions createOptions, CancellationToken cancellationToken) where TCreateOptions : ICreateOptions
    {
        var content = JsonContent.Create(createOptions, options: _jsonSerializerOptions);
        await content.LoadIntoBufferAsync();
        
        var request = new HttpRequestMessage()
        {
            RequestUri = _httpClient.ClassUrl(_endpoint),
            Method = HttpMethod.Post,
            Content = content,
        };
        
        return await SendAsync<TEntity>(request, cancellationToken);
    }
    
    internal async Task<TEntity> UpdateEntityAsync<TUpdateOptions>(string id, TUpdateOptions updateOptions, CancellationToken cancellationToken) where TUpdateOptions : IUpdateOptions
    {
        var content = JsonContent.Create(updateOptions, options: _jsonSerializerOptions);
        await content.LoadIntoBufferAsync();
        
        var request = new HttpRequestMessage()
        {
            RequestUri = _httpClient.InstanceUrl(_endpoint, id),
            Method = HttpMethod.Put,
            Content = content,
        };
        
        return await SendAsync<TEntity>(request, cancellationToken);
    }
    
    internal async Task DeleteEntityAsync(string id, CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage()
        {
            RequestUri = _httpClient.InstanceUrl(_endpoint, id),
            Method = HttpMethod.Delete,
        };
        
        var response = await _httpClient.SendAsync(request, cancellationToken);
        await response.HandleErrorResponseAsync();
    }
    
    
    private async Task<T> SendAsync<T>(HttpRequestMessage request, CancellationToken cancellationToken) 
    {
        var response = await _httpClient.SendAsync(request, cancellationToken);
        await response.HandleErrorResponseAsync();

        var contentString = await response.Content.ReadAsStringAsync();
        return await response.Content.ReadFromJsonAsync<T>(_jsonSerializerOptions);
    }
}