using Close.Helpers;
using Close.Interfaces;
using Close.Models.Common;
using Close.Models.Leads;

namespace Close.Services;

public class Leads : Service<Lead>, IRetrievable<Lead>, IListable<Lead, LeadsListOptions>, ICreatable<Lead, LeadCreateOptions>, IUpdatable<Lead, LeadUpdateOptions>, IDeletable
{
    public Leads(CloseClient closeClient, string endpoint) : base(closeClient, endpoint)
    {
    }
    
    public async Task<Lead> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        return await _request.GetEntityAsync(id, cancellationToken);
    }
    
    public async Task<CloseList<Lead>> ListAsync(LeadsListOptions options = null, CancellationToken cancellationToken = default)
    {
        return await _request.ListEntitiesAsync(options, cancellationToken);
    }
    
    public async Task<Lead> CreateAsync(LeadCreateOptions createOptions, CancellationToken cancellationToken = default)
    {
        return await _request.CreateEntityAsync(createOptions, cancellationToken);
    }
    
    public async Task<Lead> UpdateAsync(string id, LeadUpdateOptions updateOptions, CancellationToken cancellationToken = default)
    {
        return await _request.UpdateEntityAsync(id, updateOptions, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await _request.DeleteEntityAsync(id, cancellationToken);
    }
}