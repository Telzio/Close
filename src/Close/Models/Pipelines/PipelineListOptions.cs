using System.Text.Json.Serialization;
using Close.Models.Common;

namespace Close.Models.Pipelines;

public class PipelineListOptions : IListOptions
{
    [JsonPropertyName("_skip")]
    public int? Skip { get; set; }
    
    [JsonPropertyName("_limit")]
    public int? Limit { get; set; }
    
    [JsonPropertyName("_fields")]
    public string[] Fields { get; set; }
}