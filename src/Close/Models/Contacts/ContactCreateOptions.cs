using System.Text.Json.Serialization;
using Close.Models.Common;

namespace Close.Models.Contacts;

public class ContactCreateOptions
{
    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("title")]
    public string Title { get; set; }
    
    [JsonPropertyName("emails")]
    public List<Email> Emails { get; set; }
    
    [JsonPropertyName("phones")]
    public List<PhoneCreateOptions> Phones { get; set; }
    
    [JsonPropertyName("urls")]
    public List<Url> Urls { get; set; }
    
    [JsonPropertyName("custom")]
    public Dictionary<string, object> Custom { get; set; }
}