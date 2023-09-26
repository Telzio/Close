using System.Text.Json.Serialization;
using Close.Models.Enums;

namespace Close.Models;

public class Email
{
    public Email()
    {
        
    }

    public Email(string email, EmailType type = EmailType.office)
    {
        Address = email;
        Type = type;
    }
    
    [JsonPropertyName("type")]
    public EmailType Type { get; set; }

    [JsonPropertyName("email")]
    public string Address { get; set; }
}