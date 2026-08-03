using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ApiV2PokemonEncountersResponse
{
    [JsonPropertyName("location_area")]
    public required LocationArea LocationArea { get; init; }

    [JsonPropertyName("version_details")]
    public required IReadOnlyList<VersionDetail4> VersionDetails { get; init; }
}
