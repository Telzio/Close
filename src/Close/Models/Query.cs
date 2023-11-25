using System.Text.Json.Serialization;
using Close.Models.Enums;

namespace Close.Models;

public abstract class Query
{
    [JsonPropertyName("negate")]
    public bool Negate { get; set; } = false;

    [JsonPropertyName("object_type")]
    public ObjectType? ObjectType { get; set; } = null;

    [JsonPropertyName("type")]
    public QueryType Type { get; set; } = QueryType.and;

    [JsonPropertyName("queries")]
    public List<Query> Queries { get; set; } = null;

    [JsonPropertyName("related_object_type")]
    public ObjectType? RelatedObjectType { get; set; } = null;

    [JsonPropertyName("related_query")] 
    public Query RelatedQuery { get; set; } = null;

    [JsonPropertyName("this_object_type")]
    public ObjectType? ThisObjectType { get; set; } = null;

    [JsonPropertyName("condition")]
    public Condition Condition { get; set; } = null;

    [JsonPropertyName("field")]
    public Field Field { get; set; } = null;

    [JsonPropertyName("mode")]
    public Mode? Mode { get; set; } = null;

    [JsonPropertyName("value")]
    public string Value { get; set; } = null;
}

public class SearchQuery : Query
{
}