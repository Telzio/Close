using System.Text.Json.Serialization;
using Close.Interfaces;
using Close.Models.Common;
using Close.Models.Statuses;

namespace Close.Models.Opportunities;

public class Opportunity : ICloseEntity, IHasCreatedBy, IHasUpdatedBy
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; }
    
    [JsonPropertyName("lead_name")]
    public string LeadName { get; set; }
    
    [JsonPropertyName("contact_id")]
    public string ContactId { get; set; }
    
    [JsonPropertyName("contact_name")]
    public string ContactName { get; set; }
    
    [JsonPropertyName("status_id")]
    public string StatusId { get; set; }
    
    [JsonPropertyName("status_label")]
    public string StatusLabel { get; set; }
    
    [JsonPropertyName("status_display_name")]
    public string StatusDisplayName { get; set; }
    
    [JsonPropertyName("status_type")]
    public StatusType StatusType { get; set; }
    
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }
    
    [JsonPropertyName("user_name")]
    public string UserName { get; set; }
    
    [JsonPropertyName("note")]
    public string Note { get; set; }
    
    [JsonPropertyName("date_won")]
    public DateTimeOffset? DateWon { get; set; }
    
    [JsonPropertyName("date_lost")]
    public DateTimeOffset? DateLost { get; set; }
    
    [JsonPropertyName("confidence")]
    public int Confidence { get; set; }
    
    [JsonPropertyName("value")]
    public int Value { get; set; }
    
    [JsonPropertyName("value_formatted")]
    public string ValueFormatted { get; set; }
    
    [JsonPropertyName("value_period")]
    public ValuePeriod ValuePeriod { get; set; }
    
    [JsonPropertyName("value_currency")]
    public string ValueCurrency { get; set; }

    [JsonPropertyName("expected_value")]
    public int ExpectedValue { get; set; }
    
    [JsonPropertyName("annualized_expected_value")]
    public int AnnualizedExpectedValue { get; set; }
 
    [JsonPropertyName("annualized_value")]
    public int AnnualizedValue { get; set; }
    
    [JsonPropertyName("integration_links")]
    public List<IntegrationLink> IntegrationLinks { get; set; }
    
    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }

    [JsonPropertyName("updated_by")]
    public string UpdatedBy { get; set; }
    
    [JsonPropertyName("updated_by_name")]
    public string UpdatedByName { get; set; }

    [JsonPropertyName("date_updated")]
    public DateTimeOffset? DateUpdated { get; set; }

    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }
    
    [JsonPropertyName("created_by_name")]
    public string CreatedByName { get; set; }
    
    [JsonPropertyName("date_created")]
    public DateTimeOffset DateCreated { get; set; }
    
    [JsonPropertyName("custom")]
    public Dictionary<string, object> Custom { get; set; }
}