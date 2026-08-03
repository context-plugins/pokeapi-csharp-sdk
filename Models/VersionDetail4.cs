using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record VersionDetail4
{
    [JsonPropertyName("encounter_details")]
    public required IReadOnlyList<EncounterDetails1> EncounterDetails { get; init; }

    [JsonPropertyName("max_chance")]
    public required double MaxChance { get; init; }

    [JsonPropertyName("version")]
    public required VersionModel Version { get; init; }
}
