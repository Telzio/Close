using System.Text.Json.Serialization;
using Close.Models.Common;

namespace Close.Models.Leads;

public class LeadsListOptions : IListOptions
{
    [JsonPropertyName("_skip")]
    public int? Skip { get; set; }
    
    [JsonPropertyName("_limit")]
    public int? Limit { get; set; }
    
    [JsonPropertyName("_fields")]
    public string[] Fields { get; set; }
    
    [JsonPropertyName("query")]
    public string Query { get; set; }
    
    [JsonPropertyName("lead_saved_search_id")]
    public string LeadSavedSearchId { get; set; }
}