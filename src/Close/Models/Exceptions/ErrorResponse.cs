using System.Text.Json.Serialization;

namespace Close.Models.Exceptions;

public class ErrorResponse
{
    [JsonPropertyName("error")]
    public string Error { get; set; }
}