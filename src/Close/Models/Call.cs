using System.Text.Json.Serialization;
using Close.Models.Interfaces;

namespace Close.Models;

public class Call : ICloseEntity, IHasCreatedBy, IHasUpdatedBy
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("lead_id")]
    public string LeadId { get; set; }
    
    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }
    
    [JsonPropertyName("contact_id")]
    public string ContactId { get; set; }

    [JsonPropertyName("note_html")]
    public string NoteHtml { get; set; }
    
    [JsonPropertyName("created_by_name")]
    public string CreatedByName { get; set; }
    
    [JsonPropertyName("date_created")]
    public DateTimeOffset? DateCreated { get; set; }
    
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }
    
    [JsonPropertyName("updated_by_name")]
    public string UpdatedByName { get; set; }
    
    [JsonPropertyName("date_updated")]
    public DateTimeOffset? DateUpdated { get; set; }
    
    [JsonPropertyName("updated_by")]
    public string UpdatedBy { get; set; }   
    
    [JsonPropertyName("is_to_group_number")]
    public bool IsToGroupNumber { get; set; }

    [JsonPropertyName("local_phone_formatted")]
    public string LocalPhoneFormatted { get; set; }

    [JsonPropertyName("transferred_from_user_id")]
    public string TransferredFromUserId { get; set; }

    [JsonPropertyName("transferred_from")]
    public string TransferredFrom { get; set; }

    [JsonPropertyName("quality_info")]
    public string QualityInfo { get; set; }

    [JsonPropertyName("activity_at")]
    public DateTimeOffset ActivityAt { get; set; }

    [JsonPropertyName("sequence_id")]
    public string SequenceId { get; set; }

    [JsonPropertyName("disposition")]
    public string Disposition { get; set; }

    [JsonPropertyName("local_phone")]
    public string LocalPhone { get; set; }

    [JsonPropertyName("direction")]
    public string Direction { get; set; }

    [JsonPropertyName("recording_url")]
    public string RecordingUrl { get; set; }

    [JsonPropertyName("local_country_iso")]
    public string LocalCountryIso { get; set; }

    [JsonPropertyName("users")]
    public List<string> Users { get; set; }

    [JsonPropertyName("date_answered")]
    public DateTimeOffset? DateAnswered { get; set; }

    [JsonPropertyName("transferred_to")]
    public string TransferredTo { get; set; }

    [JsonPropertyName("note")]
    public string Note { get; set; }

    [JsonPropertyName("call_method")]
    public string CallMethod { get; set; }

    [JsonPropertyName("is_forwarded")]
    public bool IsForwarded { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("sequence_subscription_id")]
    public string SequenceSubscriptionId { get; set; }

    [JsonPropertyName("user_name")]
    public string UserName { get; set; }

    [JsonPropertyName("sequence_name")]
    public string SequenceName { get; set; }

    [JsonPropertyName("remote_phone_formatted")]
    public string RemotePhoneFormatted { get; set; }

    [JsonPropertyName("voicemail_duration")]
    public int VoicemailDuration { get; set; }

    [JsonPropertyName("transferred_to_user_id")]
    public string TransferredToUserId { get; set; }

    [JsonPropertyName("recording_expires_at")]
    public DateTimeOffset? RecordingExpiresAt { get; set; }

    [JsonPropertyName("has_recording")]
    public bool HasRecording { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("dialer_saved_search_id")]
    public string DialerSavedSearchId { get; set; }

    [JsonPropertyName("dialer_id")]
    public string DialerId { get; set; }

    [JsonPropertyName("is_joinable")]
    public bool IsJoinable { get; set; }

    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    [JsonPropertyName("remote_phone")]
    public string RemotePhone { get; set; }

    [JsonPropertyName("remote_country_iso")]
    public string RemoteCountryIso { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("cost")]
    public decimal? Cost { get; set; }

    [JsonPropertyName("forwarded_to")]
    public string ForwardedTo { get; set; }

    [JsonPropertyName("_type")]
    public string Type { get; set; }

    [JsonPropertyName("voicemail_url")]
    public string VoicemailUrl { get; set; }

    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}