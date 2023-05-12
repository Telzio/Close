using System.Text.Json.Serialization;
using Close.Interfaces;

namespace Close.Models.Activities.Calls;

public class CallCreateOptions : ICreateOptions
{
    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; }
    
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("disposition")]
    public string Disposition { get; set; }
    
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("note")]
    public string Note { get; set; }
    
    [JsonPropertyName("note_html")]
    public string NoteHtml { get; set; }
    
    [JsonPropertyName("contact_id")]
    public string ContactId { get; set; }

    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    [JsonPropertyName("direction")]
    public string Direction { get; set; }

    [JsonPropertyName("recording_url")]
    public string RecordingUrl { get; set; }
    
    [JsonPropertyName("voicemail_url")]
    public string VoicemailUrl { get; set; }

    [JsonPropertyName("voicemail_duration")]
    public int VoicemailDuration { get; set; }
    
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}