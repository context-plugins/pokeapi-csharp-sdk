using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record EncounterMethodDetail
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

    [JsonPropertyName("names")]
    public required IReadOnlyList<EncounterMethodName> Names { get; init; }
}
