using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record StatDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("game_index")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int GameIndex { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_battle_only")]
    public bool? IsBattleOnly { get; init; }

    [JsonPropertyName("affecting_moves")]
    public required AffectingMoves AffectingMoves { get; init; }

    [JsonPropertyName("affecting_natures")]
    public required AffectingNatures1 AffectingNatures { get; init; }

    [JsonPropertyName("affecting_items")]
    public required IReadOnlyList<AffectingItem> AffectingItems { get; init; }

    [JsonPropertyName("characteristics")]
    public required IReadOnlyList<CharacteristicSummary> Characteristics { get; init; }

    [JsonPropertyName("move_damage_class")]
    public required MoveDamageClassSummary MoveDamageClass { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<StatName> Names { get; init; }
}
