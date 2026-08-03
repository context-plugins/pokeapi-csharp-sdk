using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokemonEntry
{
    [JsonPropertyName("entry_number")]
    public required int EntryNumber { get; init; }

    [JsonPropertyName("pokemon_species")]
    public required PokemonSpecies PokemonSpecies { get; init; }
}
