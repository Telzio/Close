namespace Close.Interfaces;

public interface IRetrievable<TEntity> where TEntity : ICloseEntity
{
    Task<TEntity> GetAsync(string id, CancellationToken cancellationToken = default);
}