using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokemonDexEntry
{
    [JsonPropertyName("entry_number")]
    public required int EntryNumber { get; init; }

    [JsonPropertyName("pokedex")]
    public required PokedexSummary Pokedex { get; init; }
}
