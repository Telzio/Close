using System.Text.Json.Serialization;
using Close.Models.Events;
using Close.Services.Interfaces;

namespace Close.Models.Webhooks;

public class Webhook<TEntity> where TEntity : ICloseEntity
{
    [JsonPropertyName("subscription_id")]
    public string SubscriptionId { get; set; }

    [JsonPropertyName("event")]
    public Event<TEntity> Event { get; set; }
}