using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Close.Extensions;
using Close.Helpers;
using Close.Models;
using Close.Models.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace Close;

public class CloseRequest<TEntity> where TEntity : ICloseEntity
{
    private readonly string _endpoint;
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonSerializerOptions = new()
    {
        Converters = { new JsonStringEnumConverter() },
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
    };
    
    public CloseRequest(CloseClient closeClient, string endpoint)
    {
        _endpoint = endpoint;
        _httpClient = closeClient._httpClient;    
    }
    
    internal async Task<T> GetEntityAsync<T>(string id, CancellationToken cancellationToken) where T : TEntity
    {
        var request = new HttpRequestMessage()
        {
            RequestUri = _httpClient.InstanceUrl(_endpoint, id),
            Method = HttpMethod.Get,
        };

        return await SendAsync<T>(request, cancellationToken);
    }
    
    internal async Task<CloseList<T>> ListEntitiesAsync<T, TListOptions>(TListOptions requestOptions, CancellationToken cancellationToken) where T : TEntity where TListOptions : IRequestOptions 
    {
        var uri = _httpClient.ClassUrl(_endpoint);
        
        if (requestOptions != null)
            uri = uri.AddQueryParameters(requestOptions);
        
        var request = new HttpRequestMessage()
        {
            RequestUri = uri,
            Method = HttpMethod.Get,
        };

        return await SendAsync<CloseList<T>>(request, cancellationToken);
    }
    
    internal async Task<T> CreateEntityAsync<T>(T createOptions, CancellationToken cancellationToken) where T : TEntity  
    {
        var content = JsonContent.Create(createOptions, options: _jsonSerializerOptions);
        await content.LoadIntoBufferAsync();
        
        var request = new HttpRequestMessage()
        {
            RequestUri = _httpClient.ClassUrl(_endpoint),
            Method = HttpMethod.Post,
            Content = content,
        };
        
        return await SendAsync<T>(request, cancellationToken);
    }
    
    internal async Task<T> UpdateEntityAsync<T>(string id, T updateOptions, CancellationToken cancellationToken) where T : TEntity
    {
        var content = JsonContent.Create(updateOptions, options: _jsonSerializerOptions);
        await content.LoadIntoBufferAsync();
        
        var request = new HttpRequestMessage()
        {
            RequestUri = _httpClient.InstanceUrl(_endpoint, id),
            Method = HttpMethod.Put,
            Content = content,
        };

        return await SendAsync<T>(request, cancellationToken);
    }
    
    internal async Task DeleteEntityAsync(string id, CancellationToken cancellationToken)
    {
        var request = new HttpRequestMessage()
        {
            RequestUri = _httpClient.InstanceUrl(_endpoint, id),
            Method = HttpMethod.Delete,
        };
        
        var response = await _httpClient.SendAsync(request, cancellationToken);
        await response.HandleErrorResponseAsync(request);
    }
    
    
    private async Task<T> SendAsync<T>(HttpRequestMessage request, CancellationToken cancellationToken) 
    {
        var response = await _httpClient.SendAsync(request, cancellationToken);
        await response.HandleErrorResponseAsync(request);
        return await response.Content.ReadFromJsonAsync<T>(_jsonSerializerOptions);
    }
}