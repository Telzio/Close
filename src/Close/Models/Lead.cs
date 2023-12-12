using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class Lead : ICloseEntity, IHasCreatedBy, IHasUpdatedBy
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null;
    
    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; } = null;
    
    [JsonPropertyName("status_id")]
    public string StatusId { get; set; } = null;
    
    [JsonPropertyName("status_label")]
    public string StatusLabel { get; set; } = null;
    
    [JsonPropertyName("contacts")]
    public List<Contact> Contacts { get; set; } = null;

    [JsonPropertyName("opportunities")]
    public List<Opportunity> Opportunities { get; set; } = null;

    [JsonPropertyName("tasks")]
    public List<Task> Tasks { get; set; } = null;
    
    [JsonPropertyName("addresses")]
    public List<Address> Addresses { get; set; } = null;
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = null;
    
    [JsonPropertyName("integration_links")]
    public List<IntegrationLink> IntegrationLinks { get; set; }
    
    [JsonPropertyName("url")]
    public string Url { get; set; } = null;
    
    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; } = null;
    
    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; } = null;
    
    [JsonPropertyName("created_by_name")]
    public string CreatedByName { get; set; } = null;
    
    [JsonPropertyName("date_created")]
    public DateTimeOffset? DateCreated { get; set; } = null;
    
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; } = null;
    
    [JsonPropertyName("updated_by_name")]
    public string UpdatedByName { get; set; } = null;
    
    [JsonPropertyName("date_updated")]
    public DateTimeOffset? DateUpdated { get; set; } = null;
    
    [JsonPropertyName("updated_by")]
    public string UpdatedBy { get; set; } = null;
}