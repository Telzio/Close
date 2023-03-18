using Close.Models.Common;

namespace Close.Services.Interfaces;

public interface IListable<TEntity> where TEntity : ICloseEntity
{
    Task<CloseList<TEntity>> ListAsync(ListRequestOptions requestOptions = null, CancellationToken cancellationToken = default);
}