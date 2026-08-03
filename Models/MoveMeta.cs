using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record MoveMeta
{
    [JsonPropertyName("ailment")]
    public required MoveMetaAilmentSummary Ailment { get; init; }

    [JsonPropertyName("category")]
    public required MoveMetaCategorySummary Category { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_hits")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? MinHits { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_hits")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? MaxHits { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_turns")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? MinTurns { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_turns")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? MaxTurns { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("drain")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Drain { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("healing")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Healing { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("crit_rate")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? CritRate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ailment_chance")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? AilmentChance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flinch_chance")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? FlinchChance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stat_chance")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? StatChance { get; init; }
}
