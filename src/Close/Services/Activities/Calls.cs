using Close.Helpers;
using Close.Interfaces;
using Close.Models.Activities.Calls;

namespace Close.Services.Activities;

public class Calls : ActivityService<Call>, ICreatable<Call, CallCreateOptions>, IDeletable
{
    public Calls(CloseClient closeClient, string endpoint) : base(closeClient, endpoint)
    {
    }

    public async Task<Call> CreateAsync(CallCreateOptions createOptions, CancellationToken cancellationToken = default)
    {
        return await _request.CreateEntityAsync(createOptions, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await _request.DeleteEntityAsync(id, cancellationToken);
    }
}