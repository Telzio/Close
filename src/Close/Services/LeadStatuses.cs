using Close.Models.Common;
using Close.Models.Statuses;
using Close.Services.Interfaces;

namespace Close.Services;

public class LeadStatuses : Service<LeadStatus>, IRetrievable<LeadStatus>, IListable<LeadStatus>, ICreatable<LeadStatus, LeadStatusCreateOptions>, IUpdatable<LeadStatus, LeadStatusUpdateOptions>, IDeletable
{
    public LeadStatuses(CloseClient closeClient, string endpoint) : base(closeClient, endpoint)
    {
    }

    public async Task<LeadStatus> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        return await _request.GetEntityAsync(id, cancellationToken);
    }
    
    public async Task<CloseList<LeadStatus>> ListAsync(CancellationToken cancellationToken = default)
    {
        return await _request.ListEntitiesAsync<IListOptions>(null, cancellationToken);
    }
    
    public async Task<LeadStatus> CreateAsync(LeadStatusCreateOptions createOptions, CancellationToken cancellationToken = default)
    {
        return await _request.CreateEntityAsync(createOptions, cancellationToken);
    }
    
    public async Task<LeadStatus> UpdateAsync(string id, LeadStatusUpdateOptions updateOptions, CancellationToken cancellationToken = default)
    {
        return await _request.UpdateEntityAsync(id, updateOptions, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await _request.DeleteEntityAsync(id, cancellationToken);
    }
}