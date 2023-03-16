using System.Text.Json.Serialization;

namespace Close.Models.Leads
{
    public class LeadCreateOptions 
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }
        
        [JsonPropertyName("status_id")]
        public string StatusId { get; set; }
        
        // [JsonPropertyName("addresses")]
        // public List<LeadAddressCreateOptions> Addresses { get; set; }
        
        // [JsonPropertyName("contacts")]
        // public List<ContactCreateOptions> Contacts { get; set; }
        
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}