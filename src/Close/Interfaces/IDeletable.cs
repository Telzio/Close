namespace Close.Interfaces;

internal interface IDeletable 
{
    Task DeleteAsync(string id, CancellationToken cancellationToken = default);
}