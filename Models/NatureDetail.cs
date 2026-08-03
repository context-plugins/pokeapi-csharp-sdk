using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record NatureDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("decreased_stat")]
    public required StatSummary DecreasedStat { get; init; }

    [JsonPropertyName("increased_stat")]
    public required StatSummary IncreasedStat { get; init; }

    [JsonPropertyName("likes_flavor")]
    public required BerryFlavorSummary LikesFlavor { get; init; }

    [JsonPropertyName("hates_flavor")]
    public required BerryFlavorSummary HatesFlavor { get; init; }

    [JsonPropertyName("berries")]
    public required IReadOnlyList<BerrySummary> Berries { get; init; }

    [JsonPropertyName("pokeathlon_stat_changes")]
    public required IReadOnlyList<PokeathlonStatChange> PokeathlonStatChanges { get; init; }

    [JsonPropertyName("move_battle_style_preferences")]
    public required IReadOnlyList<NatureBattleStylePreference> MoveBattleStylePreferences { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<NatureName> Names { get; init; }
}
