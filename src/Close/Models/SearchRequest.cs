using System.Text.Json.Serialization;

namespace Close.Models;

public class SearchRequest
{
    [JsonPropertyName("query")]
    public Query Query { get; set; }

    [JsonPropertyName("results_limit")] 
    public int? ResultsLimit { get; set; } = null;

    [JsonPropertyName("limit")] 
    public int? Limit { get; set; } = null;
    
    [JsonPropertyName("sort")]
    public List<Sorting> Sort { get; set; }

    [JsonPropertyName("include_counts")]
    public bool IncludeCounts { get; set; } = true;

    [JsonPropertyName("cursor")]
    public string Cursor { get; set; } = null;
    
    [JsonPropertyName("_fields")]
    public Dictionary<string, string[]> Fields { get; set; }
}