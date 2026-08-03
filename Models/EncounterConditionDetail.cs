using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EncounterConditionDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("values")]
    public required IReadOnlyList<EncounterConditionValueSummary> Values { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<EncounterConditionName> Names { get; init; }
}
