using System.Text.Json.Serialization;

namespace Close.Services.Interfaces;

public interface IHasUpdatedBy
{
    [JsonPropertyName("date_updated")]
    public DateTimeOffset? DateUpdated { get; set; }
        
    [JsonPropertyName("updated_by")]
    public string UpdatedBy { get; set; }
}