using Close.Models.Common;

namespace Close.Services.Interfaces;

public interface IListable<TEntity, TListOptions> where TEntity : ICloseEntity where TListOptions : IListOptions
{
    Task<CloseList<TEntity>> ListAsync(TListOptions options, CancellationToken cancellationToken = default);
}