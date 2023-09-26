using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class LeadStatus : ICloseEntity
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("label")]
    public string Label { get; set; }
    
    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }
}