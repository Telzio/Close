using Close.Models.Common;
using Close.Models.Statuses;
using Close.Services.Interfaces;

namespace Close.Services;

public class OpportunityStatuses : Service<OpportunityStatus>, IRetrievable<OpportunityStatus>, IListable<OpportunityStatus>, ICreatable<OpportunityStatus, OpportunityStatusCreateOptions>, IUpdatable<OpportunityStatus, OpportunityStatusUpdateOptions>, IDeletable
{
    public OpportunityStatuses(CloseClient closeClient, string endpoint) : base(closeClient, endpoint)
    {
    }

    public async Task<OpportunityStatus> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        return await _request.GetEntityAsync(id, cancellationToken);
    }

    public async Task<CloseList<OpportunityStatus>> ListAsync(CancellationToken cancellationToken = default)
    {
        return await _request.ListEntitiesAsync<IListOptions>(null, cancellationToken);
    }

    public async Task<OpportunityStatus> CreateAsync(OpportunityStatusCreateOptions createOptions, CancellationToken cancellationToken = default)
    {
        return await _request.CreateEntityAsync(createOptions, cancellationToken);
    }

    public async Task<OpportunityStatus> UpdateAsync(string id, OpportunityStatusUpdateOptions updateOptions, CancellationToken cancellationToken = default)
    {
        return await _request.UpdateEntityAsync(id, updateOptions, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await _request.DeleteEntityAsync(id, cancellationToken);
    }
}