using Close.Interfaces;

namespace Close.Helpers;

public abstract class Service<TEntity> where TEntity : ICloseEntity
{
    protected Request<TEntity> _request;
    
    public Service(CloseClient closeClient, string endpoint)
    {
        _request = new Request<TEntity>(closeClient, endpoint);
    }
}