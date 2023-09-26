using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class CloseList<T> where T : ICloseEntity
{
    [JsonPropertyName("data")]
    public List<T> Data { get; set; }

    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
        
    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}