using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record MoveDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accuracy")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Accuracy { get; init; }

    [JsonPropertyName("effect_chance")]
    public required int EffectChance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pp")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Pp { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Priority { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("power")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Power { get; init; }

    [JsonPropertyName("contest_combos")]
    public required ContestCombos ContestCombos { get; init; }

    [JsonPropertyName("contest_type")]
    public required ContestTypeSummary ContestType { get; init; }

    [JsonPropertyName("contest_effect")]
    public required ContestEffectSummary ContestEffect { get; init; }

    [JsonPropertyName("damage_class")]
    public required MoveDamageClassSummary DamageClass { get; init; }

    [JsonPropertyName("effect_entries")]
    public required IReadOnlyList<EffectEntry> EffectEntries { get; init; }

    [JsonPropertyName("effect_changes")]
    public required IReadOnlyList<EffectChange> EffectChanges { get; init; }

    [JsonPropertyName("generation")]
    public required GenerationSummary Generation { get; init; }

    [JsonPropertyName("meta")]
    public required MoveMeta Meta { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<MoveName> Names { get; init; }

    [JsonPropertyName("past_values")]
    public required IReadOnlyList<MoveChange> PastValues { get; init; }

    [JsonPropertyName("stat_changes")]
    public required IReadOnlyList<StatChange> StatChanges { get; init; }

    [JsonPropertyName("super_contest_effect")]
    public required SuperContestEffectSummary SuperContestEffect { get; init; }

    [JsonPropertyName("target")]
    public required MoveTargetSummary Target { get; init; }

    [JsonPropertyName("type")]
    public required TypeSummary Type { get; init; }

    [JsonPropertyName("machines")]
    public required IReadOnlyList<Machine1> Machines { get; init; }

    [JsonPropertyName("flavor_text_entries")]
    public required IReadOnlyList<MoveFlavorText> FlavorTextEntries { get; init; }

    [JsonPropertyName("learned_by_pokemon")]
    public required IReadOnlyList<LearnedByPokemon> LearnedByPokemon { get; init; }
}
