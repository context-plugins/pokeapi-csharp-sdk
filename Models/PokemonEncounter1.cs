using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokemonEncounter1
{
    [JsonPropertyName("base_score")]
    public required int BaseScore { get; init; }

    [JsonPropertyName("pokemon-species")]
    public required PokemonSpecies PokemonSpecies { get; init; }

    [JsonPropertyName("rate")]
    public required int Rate { get; init; }
}
