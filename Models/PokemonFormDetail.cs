using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record PokemonFormDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Order { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("form_order")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? FormOrder { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_battle_only")]
    public bool? IsBattleOnly { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_mega")]
    public bool? IsMega { get; init; }

    [JsonPropertyName("form_name")]
    [MaxLength(30)]
    public required string FormName { get; init; }

    [JsonPropertyName("pokemon")]
    public required PokemonSummary Pokemon { get; init; }

    [JsonPropertyName("sprites")]
    public required Sprites2 Sprites { get; init; }

    [JsonPropertyName("version_group")]
    public required VersionGroupSummary VersionGroup { get; init; }

    [JsonPropertyName("form_names")]
    public required IReadOnlyList<FormName> FormNames { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<Name> Names { get; init; }

    [JsonPropertyName("types")]
    public required IReadOnlyList<TypeModel> Types { get; init; }

    [JsonPropertyName("trigger_conditions")]
    public required IReadOnlyList<TriggerCondition> TriggerConditions { get; init; }
}
