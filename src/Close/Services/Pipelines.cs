using Close.Models.Common;
using Close.Models.Pipelines;
using Close.Services.Interfaces;

namespace Close.Services;

public class Pipelines : Service<Pipeline>, IRetrievable<Pipeline>, IListable<Pipeline, PipelineListOptions>, ICreatable<Pipeline, PipelineCreateOptions>, IUpdatable<Pipeline, PipelineUpdateOptions>, IDeletable
{
    public Pipelines(CloseClient closeClient, string endpoint) : base(closeClient, endpoint)
    {
    }

    public async Task<Pipeline> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        return await _request.GetEntityAsync(id, cancellationToken);
    }

    public async Task<CloseList<Pipeline>> ListAsync(PipelineListOptions options, CancellationToken cancellationToken = default)
    {
        return await _request.ListEntitiesAsync(options, cancellationToken);
    }

    public async Task<Pipeline> CreateAsync(PipelineCreateOptions createOptions, CancellationToken cancellationToken = default)
    {
        return await _request.CreateEntityAsync(createOptions, cancellationToken);
    }

    public async Task<Pipeline> UpdateAsync(string id, PipelineUpdateOptions updateOptions, CancellationToken cancellationToken = default)
    {
        return await _request.UpdateEntityAsync(id, updateOptions, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await _request.DeleteEntityAsync(id, cancellationToken);
    }
}