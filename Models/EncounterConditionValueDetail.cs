using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EncounterConditionValueDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("condition")]
    public required EncounterConditionSummary Condition { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<EncounterConditionValueName> Names { get; init; }
}
