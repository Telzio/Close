using Close.Helpers;
using Close.Models.Common;

namespace Close.Services;

public abstract class Service<TEntityReturned> where TEntityReturned : ICloseEntity
{
    protected readonly HttpRequest<TEntityReturned> Request;

    public Service(CloseClient closeClient, string endpoint)
    {
        Request = new HttpRequest<TEntityReturned>(closeClient, endpoint);
    }
    
    public async Task<TEntityReturned> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        return await Request.ExecuteAsync(HttpMethod.Get, id, cancellationToken);
    }
}