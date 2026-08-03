using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record RegionDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("locations")]
    public required IReadOnlyList<LocationSummary> Locations { get; init; }

    [JsonPropertyName("main_generation")]
    public required GenerationSummary? MainGeneration { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<RegionName> Names { get; init; }

    [JsonPropertyName("pokedexes")]
    public required IReadOnlyList<PokedexSummary> Pokedexes { get; init; }

    [JsonPropertyName("version_groups")]
    public required IReadOnlyList<VersionGroup> VersionGroups { get; init; }
}
