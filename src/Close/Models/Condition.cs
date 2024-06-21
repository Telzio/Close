using System.Text.Json.Serialization;

namespace Close.Models;

public class Condition
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("values")]
    public List<string> Values { get; set; }
    
    [JsonPropertyName("gte")]
    public int? Gte { get; set; }
    
    [JsonPropertyName("lte")]
    public int? Lte { get; set; }
}