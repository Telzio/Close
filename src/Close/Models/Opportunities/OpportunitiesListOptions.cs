using System.Text.Json.Serialization;
using Close.Models.Common;

namespace Close.Models.Opportunities;

public class OpportunitiesListOptions : IListOptions
{
    [JsonPropertyName("_skip")]
    public int? Skip { get; set; }
    
    [JsonPropertyName("_limit")]
    public int? Limit { get; set; }
    
    [JsonPropertyName("_fields")]
    public string[] Fields { get; set; }
    
    [JsonPropertyName("_order_by")]
    public string OrderBy { get; set; }
    
    [JsonPropertyName("_group_by")]
    public string GroupBy { get; set; }
    
    [JsonPropertyName("lead_id")]
    public int? LeadId { get; set; }
    
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }
    
    [JsonPropertyName("status_id")]
    public string StatusId { get; set; }
    
    [JsonPropertyName("status_label")]
    public string StatusLabel { get; set; }
    
    [JsonPropertyName("status_type")]
    public string StatusType { get; set; }
    
    [JsonPropertyName("date_created__lt")]
    public DateTimeOffset? DateCreatedLt { get; set; }
    
    [JsonPropertyName("date_created__gt")]
    public DateTimeOffset? DateCreatedGt { get; set; }
    
    [JsonPropertyName("date_created__lte")]
    public DateTimeOffset? DateCreatedLte { get; set; }
    
    [JsonPropertyName("date_created__gte")]
    public DateTimeOffset? DateCreatedGte { get; set; }
    
    [JsonPropertyName("date_updated__lt")]
    public DateTimeOffset? DateUpdatedLt { get; set; }
    
    [JsonPropertyName("date_updated__gt")]
    public DateTimeOffset? DateUpdatedGt { get; set; }
    
    [JsonPropertyName("date_updated__lte")]
    public DateTimeOffset? DateUpdatedLte { get; set; }
    
    [JsonPropertyName("date_updated__gte")]
    public DateTimeOffset? DateUpdateGte { get; set; }
    
    [JsonPropertyName("value_period")]
    public ValuePeriod? ValuePeriod { get; set; }
    
    [JsonPropertyName("query")]
    public string Query { get; set; }
    
    [JsonPropertyName("lead_saved_search_id")]
    public string LeadSavedSearchId { get; set; }
}