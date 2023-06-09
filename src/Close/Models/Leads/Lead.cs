using System.Text.Json.Serialization;
using Close.Interfaces;
using Close.Models.Common;
using Close.Models.Contacts;
using Close.Models.Opportunities;

namespace Close.Models.Leads;

public class Lead : ICloseEntity, IHasCreatedBy, IHasUpdatedBy
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }
    
    [JsonPropertyName("status_id")]
    public string StatusId { get; set; }
    
    [JsonPropertyName("status_label")]
    public string StatusLabel { get; set; }
    
    [JsonPropertyName("contacts")]
    public List<Contact> Contacts { get; set; }

    [JsonPropertyName("opportunities")]
    public List<Opportunity> Opportunities { get; set; }

    [JsonPropertyName("tasks")]
    public List<Close.Models.Tasks.Task> Tasks { get; set; }
    
    [JsonPropertyName("addresses")]
    public List<Address> Addresses { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    [JsonPropertyName("custom")]
    public Dictionary<string, object> Custom { get; set; }
    
    [JsonPropertyName("integration_links")]
    public List<IntegrationLink> IntegrationLinks { get; set; }
    
    [JsonPropertyName("url")]
    public string Url { get; set; }
    
    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; }
    
    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }
    
    [JsonPropertyName("created_by_name")]
    public string CreatedByName { get; set; }
    
    [JsonPropertyName("date_created")]
    public DateTimeOffset DateCreated { get; set; }
    
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }
    
    [JsonPropertyName("updated_by_name")]
    public string UpdatedByName { get; set; }
    
    [JsonPropertyName("date_updated")]
    public DateTimeOffset? DateUpdated { get; set; }
    
    [JsonPropertyName("updated_by")]
    public string UpdatedBy { get; set; }
}