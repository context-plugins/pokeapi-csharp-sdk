using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokemonEncounter
{
    [JsonPropertyName("pokemon")]
    public required Pokemon1 Pokemon { get; init; }

    [JsonPropertyName("version_details")]
    public required IReadOnlyList<VersionDetail2> VersionDetails { get; init; }
}
