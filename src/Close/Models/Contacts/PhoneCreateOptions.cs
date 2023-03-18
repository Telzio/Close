using System.Text.Json.Serialization;

namespace Close.Models.Contacts;

public class PhoneCreateOptions
{
    public PhoneCreateOptions(string phoneNumber, PhoneType type = PhoneType.office)
    {
        PhoneNumber = phoneNumber;
        Type = type;
    }
    
    [JsonPropertyName("phone")]
    public string PhoneNumber { get; set; }
    
    [JsonPropertyName("type")]
    public PhoneType Type { get; set; }
}