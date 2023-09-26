using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class IntegrationLink :  ICloseEntity
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}