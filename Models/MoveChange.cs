using System.Collections.Generic;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record MoveChange
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accuracy")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Accuracy { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("power")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Power { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pp")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Pp { get; init; }

    [JsonPropertyName("effect_chance")]
    public required int EffectChance { get; init; }

    [JsonPropertyName("effect_entries")]
    public required IReadOnlyList<EffectEntry> EffectEntries { get; init; }

    [JsonPropertyName("type")]
    public required TypeSummary Type { get; init; }

    [JsonPropertyName("version_group")]
    public required VersionGroupSummary VersionGroup { get; init; }
}
