using Close.Interfaces;

namespace Close.Helpers;

public abstract class ActivityService<TEntity> where TEntity : ICloseEntity
{
    protected Request<TEntity> _request;
    
    public ActivityService(CloseClient closeClient, string endpoint)
    {
        _request = new Request<TEntity>(closeClient, endpoint);
    }
}