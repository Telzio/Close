using Close.Models.Common;

namespace Close.Services.Interfaces;

public interface IRetrievable<TEntity> where TEntity : ICloseEntity
{
    Task<TEntity> GetAsync(string id, CancellationToken cancellationToken = default);
}