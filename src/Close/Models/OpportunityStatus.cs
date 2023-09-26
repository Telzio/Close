using System.Text.Json.Serialization;
using Close.Models.Enums;
using Close.Models.Interfaces;

namespace Close.Models;

public class OpportunityStatus : ICloseEntity
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("label")]
    public string Label { get; set; }
    
    [JsonPropertyName("type")]
    public StatusType Type { get; set; }
    
    [JsonPropertyName("pipeline_id")]
    public string PipelineId { get; set; }
    
    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }
}