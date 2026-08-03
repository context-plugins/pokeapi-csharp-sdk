using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record VersionGroupDetail
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

    [JsonPropertyName("generation")]
    public required GenerationSummary Generation { get; init; }

    [JsonPropertyName("move_learn_methods")]
    public required IReadOnlyList<MoveLearnMethod> MoveLearnMethods { get; init; }

    [JsonPropertyName("pokedexes")]
    public required IReadOnlyList<Pokedex> Pokedexes { get; init; }

    [JsonPropertyName("regions")]
    public required IReadOnlyList<Region> Regions { get; init; }

    [JsonPropertyName("versions")]
    public required IReadOnlyList<VersionSummary> Versions { get; init; }
}
