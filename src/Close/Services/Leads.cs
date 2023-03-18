using Close.Models.Common;
using Close.Models.Leads;
using Close.Services.Interfaces;

namespace Close.Services;

public class Leads : Service, IRetrievable<Lead>, IListable<Lead>, ICreatable<Lead, LeadCreateOptions>, IDeletable
{
    public Leads(CloseClient closeClient) : base(closeClient, "lead")
    {
    }
    
    public async Task<Lead> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        return await _request.GetEntityAsync(id, cancellationToken);
    }
    
    public async Task<CloseList<Lead>> ListAsync(ListRequestOptions requestOptions = null, CancellationToken cancellationToken = default)
    {
        return await _request.ListEntitiesAsync(requestOptions, cancellationToken);
    }
    
    public async Task<Lead> CreateAsync(LeadCreateOptions createOptions, CancellationToken cancellationToken = default)
    {
        return await _request.CreateEntityAsync(createOptions, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await _request.DeleteEntityAsync(id, cancellationToken);
    }
}