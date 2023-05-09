using System.Text.Json.Serialization;
using Close.Interfaces;

namespace Close.Models.Common;

public class CloseList<TEntityReturned> where TEntityReturned : ICloseEntity
{
    [JsonPropertyName("data")]
    public List<TEntityReturned> Data { get; set; }

    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
        
    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}