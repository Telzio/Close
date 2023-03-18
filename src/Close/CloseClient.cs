using Close.Services;

namespace Close;

public interface ICloseClient
{
    Leads Leads { get; }
    Opportunities Opportunities { get; }
}

public class CloseClient : ICloseClient
{
    internal readonly HttpClient _httpClient;
    
    public CloseClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Leads Leads => new(this, "lead");
    public Opportunities Opportunities => new(this, "opportunity");
}