using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class Contact : ICloseEntity, IHasCreatedBy, IHasUpdatedBy
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
    
    [JsonPropertyName("emails")]
    public List<Email> Emails { get; set; }
    
    [JsonPropertyName("phones")]
    public List<Phone> Phones { get; set; }
    
    [JsonPropertyName("integration_links")]
    public List<IntegrationLink> IntegrationLinks { get; set; }
    
    [JsonPropertyName("urls")]
    public List<Url> Urls { get; set; }

    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }

    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    [JsonPropertyName("date_created")]
    public DateTimeOffset DateCreated { get; set; }
    
    [JsonPropertyName("updated_by")]
    public string UpdatedBy { get; set; }

    [JsonPropertyName("date_updated")]
    public DateTimeOffset? DateUpdated { get; set; }
}