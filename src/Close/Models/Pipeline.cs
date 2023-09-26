using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class Pipeline : ICloseEntity, IHasCreatedBy, IHasUpdatedBy
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("statuses")]
    public List<OpportunityStatus> Statuses { get; set; }

    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }
    
    [JsonPropertyName("date_created")]
    public DateTimeOffset DateCreated { get; set; }

    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    [JsonPropertyName("date_updated")]
    public DateTimeOffset? DateUpdated { get; set; }
    
    [JsonPropertyName("updated_by")]
    public string UpdatedBy { get; set; }
}