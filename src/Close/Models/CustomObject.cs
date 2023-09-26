using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class CustomObject : ICloseEntity, IHasCreatedBy, IHasUpdatedBy
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("custom_object_type_id")]
    public string CustomObjectTypeId { get; set; }
    
    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
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