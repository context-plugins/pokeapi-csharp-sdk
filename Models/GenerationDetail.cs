using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record GenerationDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("abilities")]
    public required IReadOnlyList<AbilitySummary> Abilities { get; init; }

    [JsonPropertyName("main_region")]
    public required RegionSummary MainRegion { get; init; }

    [JsonPropertyName("moves")]
    public required IReadOnlyList<MoveSummary> Moves { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<GenerationName> Names { get; init; }

    [JsonPropertyName("pokemon_species")]
    public required IReadOnlyList<PokemonSpeciesSummary> PokemonSpecies { get; init; }

    [JsonPropertyName("types")]
    public required IReadOnlyList<TypeSummary> Types { get; init; }

    [JsonPropertyName("version_groups")]
    public required IReadOnlyList<VersionGroupSummary> VersionGroups { get; init; }
}
