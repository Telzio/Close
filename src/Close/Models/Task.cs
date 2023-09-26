using System.Text.Json.Serialization;
using Close.Models.Enums;
using Close.Models.Interfaces;

namespace Close.Models;

public class Task : IHasCreatedBy, IHasUpdatedBy
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("_type")]
    public TaskType Type { get; set; }
    
    [JsonPropertyName("object_id")]
    public string ObjectId { get; set; }
    
    [JsonPropertyName("object_type")]
    public ObjectType? ObjectType { get; set; }
    
    [JsonPropertyName("text")]
    public string Text { get; set; }
    
    [JsonPropertyName("assigned_to")]
    public string AssignedTo { get; set; }
    
    [JsonPropertyName("assigned_to_name")]
    public string AssignedToName { get; set; }
    
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; set; }

    [JsonPropertyName("is_dateless")]
    public bool IsDateless { get; set; }
    
    [JsonPropertyName("due_date")]
    public DateTimeOffset? DueDate { get; set; }
    
    [JsonPropertyName("is_complete")]
    public bool IsComplete { get; set; }  

    [JsonPropertyName("view")]
    public string View { get; set; }
    
    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; }
    
    [JsonPropertyName("lead_name")]
    public string LeadName { get; set; }

    [JsonPropertyName("contact_id")]
    public string ContactId { get; set; }
    
    [JsonPropertyName("contact_name")]
    public string ContactName { get; set; }

    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }

    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }
    
    [JsonPropertyName("created_by_name")]
    public string CreatedByName { get; set; }
        
    [JsonPropertyName("date_created")]
    public DateTimeOffset DateCreated { get; set; }
        
    [JsonPropertyName("updated_by")]
    public string UpdatedBy { get; set; }
        
    [JsonPropertyName("updated_by_name")]
    public string UpdatedByName { get; set; }
        
    [JsonPropertyName("date_updated")]
    public DateTimeOffset? DateUpdated { get; set; }
}