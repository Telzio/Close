using System.Text.Json.Serialization;
using Close.Interfaces;

namespace Close.Models.Activities.Notes;

public class NoteUpdateOptions : IUpdateOptions
{
    [JsonPropertyName("note")]
    public string Note { get; set; }
    
    [JsonPropertyName("note_html")]
    public string NoteHtml { get; set; }
}