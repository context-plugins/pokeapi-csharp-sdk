using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EffectEntry2
{
    [JsonPropertyName("effect")]
    public required string Effect { get; init; }

    [JsonPropertyName("language")]
    public required Language Language { get; init; }
}
