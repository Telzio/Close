using System.Text.Json.Serialization;
using Close.Interfaces;

namespace Close.Models.Opportunities;

public class OpportunityCreateOptions : ICreateOptions
{
    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; }
    
    [JsonPropertyName("status_id")]
    public string StatusId { get; set; }
    
    [JsonPropertyName("contact_id")]
    public string ContactId { get; set; }
    
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

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
    
    [JsonPropertyName("value_period")]
    public ValuePeriod ValuePeriod { get; set; }
    
    [JsonPropertyName("value_currency")]
    public string ValueCurrency { get; set; }

    [JsonPropertyName("custom")]
    public Dictionary<string, object> Custom { get; set; }
}