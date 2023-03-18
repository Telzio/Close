using Close.Models.Common;

namespace Close.Services.Interfaces;

public interface IUpdatable<TEntity, TUpdateOptions> where TEntity : ICloseEntity where TUpdateOptions : IUpdateOptions, new()
{
    Task<TEntity> UpdateAsync(string id, TUpdateOptions updateOptions, CancellationToken cancellationToken = default);
}