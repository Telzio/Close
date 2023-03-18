using System.Text.Json.Serialization;

namespace Close.Models.Common;

public interface IHasCreatedBy
{
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }
    
    [JsonPropertyName("date_created")]
    public DateTimeOffset DateCreated { get; set; }
}