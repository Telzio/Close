using System.Text.Json.Serialization;

namespace Close.Models;

public class Url
{
    public Url()
    {
        
    }

    public Url(string url)
    {
        Address = url;
    }
    
    [JsonPropertyName("url")]
    public string Address { get; set; }
}