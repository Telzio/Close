using Close.Models.Common;
using Close.Models.Leads;
using Close.Models.Opportunities;
using Close.Services.Interfaces;

namespace Close.Services;

public class Opportunities : Service<Opportunity>, IRetrievable<Opportunity>, IListable<Opportunity, OpportunitiesListOptions>, ICreatable<Opportunity, OpportunityCreateOptions>, IUpdatable<Opportunity, OpportunityUpdateOptions>, IDeletable
{
    public Opportunities(CloseClient closeClient, string endpoint) : base(closeClient, endpoint)
    {
    }

    public async Task<Opportunity> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        return await _request.GetEntityAsync(id, cancellationToken);
    }

    public async Task<CloseList<Opportunity>> ListAsync(OpportunitiesListOptions options = null, CancellationToken cancellationToken = default)
    {
        return await _request.ListEntitiesAsync(options, cancellationToken);
    }

    public async Task<Opportunity> CreateAsync(OpportunityCreateOptions createOptions, CancellationToken cancellationToken = default)
    {
        return await _request.CreateEntityAsync(createOptions, cancellationToken);
    }

    public async Task<Opportunity> UpdateAsync(string id, OpportunityUpdateOptions updateOptions, CancellationToken cancellationToken = default)
    {
        return await _request.UpdateEntityAsync(id, updateOptions, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await _request.DeleteEntityAsync(id, cancellationToken);
    }
}