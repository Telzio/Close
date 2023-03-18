using System.Text.Json.Serialization;

namespace Close.Models.Contacts;

public class Phone
{
    [JsonPropertyName("phone")]
    public string PhoneNumber { get; set; }
    
    [JsonPropertyName("phone_formatted")]
    public string PhoneFormatted { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("type")]
    public PhoneType Type { get; set; }
}