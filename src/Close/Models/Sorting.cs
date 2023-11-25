using System.Text.Json.Serialization;

namespace Close.Models;

public class Sorting
{
    [JsonPropertyName("direction")]
    public string Direction { get; set; }

    [JsonPropertyName("field")]
    public Field Field { get; set; }
}