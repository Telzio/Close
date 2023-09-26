using System.Text.Json.Serialization;

namespace Close.Models.Exceptions;

public class ApiError
{
    [JsonPropertyName("error")]
    public string Error { get; set; }
    
    [JsonPropertyName("errors")]
    public List<Error> Errors { get; set; }
    
    [JsonPropertyName("field-errors")]
    public Dictionary<string, string> FieldErrors { get; set; }
}

public class Error
{
    
}