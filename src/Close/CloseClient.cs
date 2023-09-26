using Close.Helpers;
using Close.Models;

namespace Close;

public interface ICloseClient
{
    CloseService<Lead, ListRequestOptions> Leads { get; }
    CloseService<Contact, ListRequestOptions> Contacts { get; }
    CloseService<LeadStatus, ListRequestOptions> LeadStatuses { get; }
    CloseService<Opportunity, ListRequestOptions> Opportunities { get; }
    CloseService<OpportunityStatus, ListRequestOptions> OpportunityStatuses { get; }
    CloseService<Pipeline, ListRequestOptions> Pipelines { get; }
    CloseService<CustomObject, CustomObjectListRequestOptions> CustomObjects { get; }
    CloseService<Note, ListRequestOptions> Notes { get; }
    CloseService<Call, ListRequestOptions> Calls { get; }
    CloseService<IntegrationLink, ListRequestOptions> IntegrationLinks { get; }
}

public class CloseClient : ICloseClient
{
    internal readonly HttpClient _httpClient;
    
    public CloseClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public CloseService<Lead, ListRequestOptions> Leads => new(this, "lead");
    public CloseService<Contact, ListRequestOptions> Contacts => new(this, "contact");
    public CloseService<LeadStatus, ListRequestOptions> LeadStatuses => new(this, "status/lead");
    public CloseService<Pipeline, ListRequestOptions> Pipelines => new(this, "pipeline");
    public CloseService<Opportunity, ListRequestOptions> Opportunities => new(this, "opportunity");
    public CloseService<OpportunityStatus, ListRequestOptions> OpportunityStatuses => new(this, "status/opportunity");
    public CloseService<CustomObject, CustomObjectListRequestOptions> CustomObjects => new(this, "custom_object");
    public CloseService<Note, ListRequestOptions> Notes => new(this, "activity/note");
    public CloseService<Call, ListRequestOptions> Calls => new(this, "activity/call");
    public CloseService<IntegrationLink, ListRequestOptions> IntegrationLinks => new(this, "integration_link");
}
