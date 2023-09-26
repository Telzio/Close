using System.Text.Json.Serialization;

namespace Close.Models;

public class Address
{
    public Address()
    {
        
    }

    public Address(string label = null, string address1 = null, string address2 = null, string city = null, string zipcode = null, string state = null, string country = null)
    {
        Label = label;
        Address1 = address1;
        Address2 = address2;
        City = city;
        Zipcode = zipcode;
        State = state;
        Country = country;
    }
    
    [JsonPropertyName("label")]
    public string Label { get; set; }
    
    [JsonPropertyName("address_1")]
    public string Address1 { get; set; }

    [JsonPropertyName("address_2")]
    public string Address2 { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("zipcode")]
    public string Zipcode { get; set; }
    
    [JsonPropertyName("state")]
    public string State { get; set; }
    
    [JsonPropertyName("country")]
    public string Country { get; set; }
}