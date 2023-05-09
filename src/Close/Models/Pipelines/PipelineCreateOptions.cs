using System.Text.Json.Serialization;
using Close.Interfaces;

namespace Close.Models.Pipelines;

public class PipelineCreateOptions : ICreateOptions
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}