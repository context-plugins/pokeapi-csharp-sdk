using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EncounterDetails1
{
    [JsonPropertyName("chance")]
    public required double Chance { get; init; }

    [JsonPropertyName("condition_values")]
    public required IReadOnlyList<ConditionValues> ConditionValues { get; init; }

    [JsonPropertyName("max_level")]
    public required double MaxLevel { get; init; }

    [JsonPropertyName("method")]
    public required Method Method { get; init; }

    [JsonPropertyName("min_level")]
    public required double MinLevel { get; init; }
}
