using System.Text.Json.Serialization;
using Close.Services.Interfaces;

namespace Close.Models.Statuses;

public class LeadStatus : ICloseEntity
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("label")]
    public string Label { get; set; }
    
    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }
}