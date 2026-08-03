using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Pokemon
{
    [JsonPropertyName("is_hidden")]
    public required bool IsHidden { get; init; }

    [JsonPropertyName("slot")]
    public required int Slot { get; init; }

    [JsonPropertyName("pokemon")]
    public required Pokemon1 PokemonValue { get; init; }
}
