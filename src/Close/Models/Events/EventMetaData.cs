using System.Text.Json.Serialization;

namespace Close.Models.Events;

public class EventMetaData
{
    [JsonPropertyName("request_method")]
    public string RequestMethod { get; set; }

    [JsonPropertyName("request_path")]
    public string RequestPath { get; set; }
}