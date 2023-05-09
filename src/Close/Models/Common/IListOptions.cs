using System.Text.Json.Serialization;
using Close.Interfaces;

namespace Close.Models.Common;

public interface IListOptions : IRequestOptions
{
    [JsonPropertyName("_skip")]
    public int? Skip { get; set; }
    
    [JsonPropertyName("_limit")]
    public int? Limit { get; set; }
    
    [JsonPropertyName("_fields")]
    public string[] Fields { get; set; }
 }