using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Variety
{
    [JsonPropertyName("is_default")]
    public required bool IsDefault { get; init; }

    [JsonPropertyName("pokemon")]
    public required Pokemon1 Pokemon { get; init; }
}
