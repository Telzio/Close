using System.Text.Json.Serialization;
using Close.Services.Interfaces;

namespace Close.Models.Common;

public class ListRequestOptions : IRequestOptions
{
    [JsonPropertyName("_skip")]
    public int? Skip { get; set; }
    
    [JsonPropertyName("_limit")]
    public int? Limit { get; set; }
}