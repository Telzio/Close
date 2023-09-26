using System.Text.Json.Serialization;
using Close.Models.Enums;
using Close.Models.Interfaces;

namespace Close.Models;

public class Event<TEntity> : ICloseEntity where TEntity : ICloseEntity
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("action")]
    public EventAction Action { get; set; }

    [JsonPropertyName("changed_fields")]
    public List<string> ChangedFields { get; set; }
    
    [JsonPropertyName("data")]
    public TEntity Data { get; set; }
    
    [JsonPropertyName("previous_data")]
    public TEntity PreviousData { get; set; }
    
    [JsonPropertyName("object_id")]
    public string ObjectId { get; set; }
    
    [JsonPropertyName("object_type")]
    public ObjectType ObjectType { get; set; }
    
    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; }

    [JsonPropertyName("meta")]
    public EventMetaData Meta { get; set; }

    [JsonPropertyName("api_key_id")]
    public string ApiKeyId { get; set; }
    
    [JsonPropertyName("request_id")]
    public string RequestId { get; set; }
    
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }
    
    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }
     
    [JsonPropertyName("date_created")]
    public DateTimeOffset DateCreated { get; set; }
    
    [JsonPropertyName("date_updated")]
    public DateTimeOffset DateUpdated { get; set; }
}