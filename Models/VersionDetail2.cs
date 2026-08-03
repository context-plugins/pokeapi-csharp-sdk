using System.Text.Json.Serialization;

namespace PokApi.Models;

public record VersionDetail2
{
    [JsonPropertyName("version")]
    public required VersionModel Version { get; init; }

    [JsonPropertyName("max_chance")]
    public required int MaxChance { get; init; }

    [JsonPropertyName("encounter_details")]
    public required EncounterDetails EncounterDetails { get; init; }
}
