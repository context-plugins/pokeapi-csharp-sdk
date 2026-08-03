using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record HeldByPokemon
{
    [JsonPropertyName("pokemon")]
    public required Pokemon1 Pokemon { get; init; }

    [JsonPropertyName("version-details")]
    public required IReadOnlyList<VersionDetail3> VersionDetails { get; init; }
}
