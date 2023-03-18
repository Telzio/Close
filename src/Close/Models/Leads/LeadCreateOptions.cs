using System.Text.Json.Serialization;
using Close.Helpers;
using Close.Models.Common;
using Close.Models.Contacts;

namespace Close.Models.Leads
{
    public class LeadCreateOptions : ICreateOptions 
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
        
        [JsonPropertyName("custom")]
        //[JsonConverter(typeof(CustomFieldsJsonConverter))]
        public Dictionary<string, object> Custom { get; set; }
    }
}