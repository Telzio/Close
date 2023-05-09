using Close.Services.Activities;

namespace Close.Services;

public interface IActivity
{
    Notes Notes { get; }
}

public class Activity : IActivity
{
    private readonly CloseClient _closeClient;
    private readonly string _endpoint;

    public Activity(CloseClient closeClient, string endpoint)
    {
        _closeClient = closeClient;
        _endpoint = endpoint;
    }
    
    public Notes Notes => new(_closeClient, $"{_endpoint}/note");
}