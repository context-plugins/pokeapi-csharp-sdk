using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record PokemonDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_experience")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? BaseExperience { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("height")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Height { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Order { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weight")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Weight { get; init; }

    [JsonPropertyName("abilities")]
    public required IReadOnlyList<Ability> Abilities { get; init; }

    [JsonPropertyName("past_abilities")]
    public required IReadOnlyList<PastAbility> PastAbilities { get; init; }

    [JsonPropertyName("forms")]
    public required IReadOnlyList<PokemonFormSummary> Forms { get; init; }

    [JsonPropertyName("game_indices")]
    public required IReadOnlyList<PokemonGameIndex> GameIndices { get; init; }

    [JsonPropertyName("held_items")]
    public required IReadOnlyList<HeldItem1> HeldItems { get; init; }

    [JsonPropertyName("location_area_encounters")]
    public required string LocationAreaEncounters { get; init; }

    [JsonPropertyName("moves")]
    public required IReadOnlyList<Move2> Moves { get; init; }

    [JsonPropertyName("species")]
    public required PokemonSpeciesSummary Species { get; init; }

    [JsonPropertyName("sprites")]
    public required Sprites1 Sprites { get; init; }

    [JsonPropertyName("cries")]
    public required Cries Cries { get; init; }

    [JsonPropertyName("stats")]
    public required IReadOnlyList<PokemonStat> Stats { get; init; }

    [JsonPropertyName("past_stats")]
    public required IReadOnlyList<PastStat> PastStats { get; init; }

    [JsonPropertyName("types")]
    public required IReadOnlyList<TypeModel> Types { get; init; }

    [JsonPropertyName("past_types")]
    public required IReadOnlyList<PastType> PastTypes { get; init; }
}
