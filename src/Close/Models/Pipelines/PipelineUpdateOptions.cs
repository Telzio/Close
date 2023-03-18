using System.Text.Json.Serialization;
using Close.Services.Interfaces;

namespace Close.Models.Pipelines;

public class PipelineUpdateOptions : IUpdateOptions
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("statuses")]
    public Dictionary<string, string> Statuses { get; set; }
}