using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

/// <summary>
/// Serializer for the Type resource
/// </summary>
public record TypeDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("damage_relations")]
    public required DamageRelations DamageRelations { get; init; }

    [JsonPropertyName("past_damage_relations")]
    public required IReadOnlyList<PastDamageRelation> PastDamageRelations { get; init; }

    [JsonPropertyName("game_indices")]
    public required IReadOnlyList<TypeGameIndex> GameIndices { get; init; }

    [JsonPropertyName("generation")]
    public required GenerationSummary Generation { get; init; }

    [JsonPropertyName("move_damage_class")]
    public required MoveDamageClassSummary MoveDamageClass { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<AbilityName> Names { get; init; }

    [JsonPropertyName("pokemon")]
    public required IReadOnlyList<Pokemon5> Pokemon { get; init; }

    [JsonPropertyName("moves")]
    public required IReadOnlyList<MoveSummary> Moves { get; init; }

    [JsonPropertyName("sprites")]
    public required IReadOnlyDictionary<string, Sprites3> Sprites { get; init; }
}
