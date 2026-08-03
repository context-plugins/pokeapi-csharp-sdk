using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokedexDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_main_series")]
    public bool? IsMainSeries { get; init; }

    [JsonPropertyName("descriptions")]
    public required IReadOnlyList<PokedexDescription> Descriptions { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<PokedexName> Names { get; init; }

    [JsonPropertyName("pokemon_entries")]
    public required IReadOnlyList<PokemonEntry> PokemonEntries { get; init; }

    [JsonPropertyName("region")]
    public required RegionSummary Region { get; init; }

    [JsonPropertyName("version_groups")]
    public required IReadOnlyList<VersionGroup> VersionGroups { get; init; }
}
