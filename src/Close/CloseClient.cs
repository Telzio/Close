using Close.Services;

namespace Close;

public interface ICloseClient
{
    Leads Leads { get; }
    LeadStatuses LeadStatuses { get; }
    Opportunities Opportunities { get; }
    OpportunityStatuses OpportunityStatuses { get; }
    Pipelines Pipelines { get; }
}

public class CloseClient : ICloseClient
{
    internal readonly HttpClient _httpClient;
    
    public CloseClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Leads Leads => new(this, "lead");
    public LeadStatuses LeadStatuses => new(this, "status/lead");
    public Opportunities Opportunities => new(this, "opportunity");
    public OpportunityStatuses OpportunityStatuses => new(this, "status/opportunity");
    public Pipelines Pipelines => new(this, "pipeline");
}