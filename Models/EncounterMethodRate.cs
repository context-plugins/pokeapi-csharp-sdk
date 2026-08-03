using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EncounterMethodRate
{
    [JsonPropertyName("encounter_method")]
    public required EncounterMethod EncounterMethod { get; init; }

    [JsonPropertyName("version_details")]
    public required IReadOnlyList<VersionDetail1> VersionDetails { get; init; }
}
