using System.Text.Json.Serialization;

namespace Close.Models;

public class CustomObjectListRequestOptions : ListRequestOptions
{
    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; } 
}