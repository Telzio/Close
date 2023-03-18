using Close.Models.Common;

namespace Close.Services.Interfaces;

public interface ICreatable<TEntity, TCreateOptions> where TEntity : ICloseEntity where TCreateOptions : ICreateOptions, new()
{
    Task<TEntity> CreateAsync(TCreateOptions createOptions, CancellationToken cancellationToken = default);
}