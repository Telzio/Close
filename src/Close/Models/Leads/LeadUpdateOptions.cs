using System.Text.Json.Serialization;
using Close.Interfaces;
using Close.JsonConverters;
using Close.Models.Common;
using Close.Models.Contacts;

namespace Close.Models.Leads;

public class LeadUpdateOptions : IUpdateOptions
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
        
    [JsonPropertyName("status_id")]
    public string StatusId { get; set; }
        
    [JsonPropertyName("status")]
    public string Status { get; set; }
        
    [JsonPropertyName("addresses")]
    public List<Address> Addresses { get; set; }
        
    [JsonPropertyName("contacts")]
    public List<ContactCreateOptions> Contacts { get; set; }
        
    [JsonPropertyName("description")]
    public string Description { get; set; }
        
    [JsonPropertyName("url")]
    public string Url { get; set; }
    
    public CustomFields Custom { get; set; }
}