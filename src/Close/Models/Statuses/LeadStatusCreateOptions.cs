using System.Text.Json.Serialization;
using Close.Interfaces;

namespace Close.Models.Statuses;

public class LeadStatusCreateOptions : ICreateOptions
{
    [JsonPropertyName("label")]
    public string Label { get; set; }
}