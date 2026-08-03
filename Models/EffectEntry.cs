using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EffectEntry
{
    [JsonPropertyName("effect")]
    public required string Effect { get; init; }

    [JsonPropertyName("short_effect")]
    public required string ShortEffect { get; init; }

    [JsonPropertyName("language")]
    public required Language Language { get; init; }
}
