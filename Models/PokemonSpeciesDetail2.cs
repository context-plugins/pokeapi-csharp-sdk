using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokemonSpeciesDetail2
{
    [JsonPropertyName("rate")]
    public required int Rate { get; init; }

    [JsonPropertyName("pokemon_species")]
    public required PokemonSpecies PokemonSpecies { get; init; }
}
