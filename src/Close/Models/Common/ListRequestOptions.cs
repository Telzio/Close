using System.Text.Json.Serialization;

namespace Close.Models.Common;

public class ListRequestOptions : IRequestOptions
{
    [JsonPropertyName("_skip")]
    public int? Skip { get; set; }
    
    [JsonPropertyName("_limit")]
    public int? Limit { get; set; }
}