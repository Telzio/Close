using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class SearchResults<T> : ICloseEntity where T : ICloseEntity
{
    [JsonPropertyName("data")]
    public List<T> Data { get; set; }
    
    [JsonPropertyName("count")]
    public Count Count { get; set; }
    
    [JsonPropertyName("cursor")]
    public string Cursor { get; set; }
}

public class Count
{
    [JsonPropertyName("limited")]
    public int Limited { get; set; }
    
    [JsonPropertyName("total")]
    public int Total { get; set; }
}