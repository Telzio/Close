using System.Text.Json.Serialization;

namespace Close.Models.Common;

public class IntegrationLink
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}