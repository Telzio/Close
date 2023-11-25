using Close.Models;
using Close.Models.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace Close;

public class CloseService<TEntity, TListOptions> where TEntity : ICloseEntity where TListOptions : ListRequestOptions
{
    protected CloseRequest<TEntity> CloseRequest;
    
    public CloseService(CloseClient closeClient, string endpoint)
    {
        CloseRequest = new CloseRequest<TEntity>(closeClient, endpoint);
    }

    #region GET

    public virtual async Task<TEntity> GetAsync(string id, CancellationToken cancellationToken = default) 
    {
        return await CloseRequest.GetEntityAsync<TEntity>(id, cancellationToken);
    }
    
    public virtual async Task<T> GetAsync<T>(string id, CancellationToken cancellationToken = default) where T : TEntity
    {
        return await CloseRequest.GetEntityAsync<T>(id, cancellationToken);
    }

    #endregion

    #region LIST

    public virtual async Task<CloseList<TEntity>> ListAsync(TListOptions options = null, CancellationToken cancellationToken = default) 
    {
        return await CloseRequest.ListEntitiesAsync<TEntity, ListRequestOptions>(options, cancellationToken);
    }
    
    public virtual async Task<CloseList<T>> ListAsync<T>(TListOptions options = null, CancellationToken cancellationToken = default) where T : TEntity 
    {
        return await CloseRequest.ListEntitiesAsync<T, TListOptions>(options, cancellationToken);
    }

    #endregion

    #region CREATE

    public virtual async Task<TEntity> CreateAsync(TEntity options, CancellationToken cancellationToken = default) 
    {
        return await CloseRequest.CreateEntityAsync(options, cancellationToken);
    }
    
    public virtual async Task<T> CreateAsync<T>(T options, CancellationToken cancellationToken = default) where T : TEntity 
    {
        return await CloseRequest.CreateEntityAsync(options, cancellationToken);
    }

    #endregion

    #region UPDATE

    public virtual async Task<TEntity> UpdateAsync(string id, TEntity options, CancellationToken cancellationToken = default) 
    {
        return await CloseRequest.UpdateEntityAsync(id, options, cancellationToken);
    }
    
    public virtual async Task<T> UpdateAsync<T>(string id, T options, CancellationToken cancellationToken = default) where T : TEntity
    {
        return await CloseRequest.UpdateEntityAsync(id, options, cancellationToken);
    }

    #endregion
    
    #region DELETE
    
    public virtual async Task DeleteAsync(string id, CancellationToken cancellationToken = default)
    {
        await CloseRequest.DeleteEntityAsync(id, cancellationToken);
    }
    
    #endregion

    #region SEARCH

    public virtual async Task<SearchResults<TEntity>> SearchAsync<T>(T query, CancellationToken cancellationToken = default) where T : SearchRequest 
    {
        return await CloseRequest.SearchAsync<TEntity, T>(query, cancellationToken);
    }
    
    public virtual async Task<SearchResults<T>> SearchAsync<T, TT>(TT query, CancellationToken cancellationToken = default) where T : TEntity where TT : SearchRequest 
    {
        return await CloseRequest.SearchAsync<T, TT>(query, cancellationToken);
    }

    #endregion
}