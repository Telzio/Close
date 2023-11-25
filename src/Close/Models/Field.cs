using System.Text.Json.Serialization;
using Close.Models.Enums;

namespace Close.Models;

public class Field
{
    [JsonPropertyName("field_name")]
    public string FieldName { get; set; }

    [JsonPropertyName("object_type")]
    public ObjectType ObjectType { get; set; }

    [JsonPropertyName("type")]
    public FieldType Type { get; set; }
}