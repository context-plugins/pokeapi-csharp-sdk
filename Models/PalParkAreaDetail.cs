using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PalParkAreaDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<PalParkAreaName> Names { get; init; }

    [JsonPropertyName("pokemon_encounters")]
    public required IReadOnlyList<PokemonEncounter1> PokemonEncounters { get; init; }
}
