using Close.Helpers;
using Close.Interfaces;
using Close.Models.Activities.Notes;
using Close.Models.Common;

namespace Close.Services.Activities;

public class Notes : ActivityService<Note>, ICreatable<Note, NoteCreateOptions>, IUpdatable<Note, NoteUpdateOptions>, IRetrievable<Note>, IListable<Note, NoteListOptions>, IDeletable
{
    public Notes(CloseClient closeClient, string endpoint) : base(closeClient, endpoint)
    {
    }

    public async Task<Note> CreateAsync(NoteCreateOptions createOptions, CancellationToken cancellationToken = default)
    {
        return await _request.CreateEntityAsync(createOptions, cancellationToken); 
    }

    public async Task<Note> UpdateAsync(string id, NoteUpdateOptions updateOptions, CancellationToken cancellationToken = default)
    {
        return await _request.UpdateEntityAsync(id, updateOptions, cancellationToken);
    }

    public async Task<Note> GetAsync(string id, CancellationToken cancellationToken = default)
    {
        return await _request.GetEntityAsync(id, cancellationToken);
    }

    public async Task<CloseList<Note>> ListAsync(NoteListOptions options, CancellationToken cancellationToken = default)
    {
        return await _request.ListEntitiesAsync(options, cancellationToken);
    }

    public async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await _request.DeleteEntityAsync(id, cancellationToken);
    }
}