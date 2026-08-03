using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record ItemDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cost")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Cost { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fling_power")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? FlingPower { get; init; }

    [JsonPropertyName("fling_effect")]
    public required ItemFlingEffectSummary FlingEffect { get; init; }

    [JsonPropertyName("attributes")]
    public required IReadOnlyList<AttributeModel> Attributes { get; init; }

    [JsonPropertyName("category")]
    public required ItemCategorySummary Category { get; init; }

    [JsonPropertyName("effect_entries")]
    public required IReadOnlyList<ItemEffectText> EffectEntries { get; init; }

    [JsonPropertyName("flavor_text_entries")]
    public required IReadOnlyList<ItemFlavorText> FlavorTextEntries { get; init; }

    [JsonPropertyName("game_indices")]
    public required IReadOnlyList<ItemGameIndex> GameIndices { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<ItemName> Names { get; init; }

    [JsonPropertyName("held_by_pokemon")]
    public required IReadOnlyList<HeldByPokemon> HeldByPokemon { get; init; }

    [JsonPropertyName("sprites")]
    public required Sprites Sprites { get; init; }

    [JsonPropertyName("baby_trigger_for")]
    public required BabyTriggerFor BabyTriggerFor { get; init; }

    [JsonPropertyName("machines")]
    public required IReadOnlyList<Machine> Machines { get; init; }
}
