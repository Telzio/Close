using System.Text.Json.Serialization;
using Close.Services.Interfaces;

namespace Close.Models.Statuses;

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