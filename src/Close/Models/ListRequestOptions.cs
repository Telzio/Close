using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class ListRequestOptions : IRequestOptions
{
    [JsonPropertyName("_skip")]
    public int? Skip { get; set; }
    
    [JsonPropertyName("_limit")]
    public int? Limit { get; set; }
    
    [JsonPropertyName("_fields")]
    public string[] Fields { get; set; }
    
    [JsonPropertyName("_query")]
    public string Query { get; set; }
}