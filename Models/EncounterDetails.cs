using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EncounterDetails
{
    [JsonPropertyName("min_level")]
    public required int MinLevel { get; init; }

    [JsonPropertyName("max_level")]
    public required int MaxLevel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("condition_values")]
    public ConditionValues? ConditionValues { get; init; }

    [JsonPropertyName("chance")]
    public required int Chance { get; init; }

    [JsonPropertyName("method")]
    public required Method Method { get; init; }
}
