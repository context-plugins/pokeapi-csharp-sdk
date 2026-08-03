using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record AffectingNatures
{
    [JsonPropertyName("decrease")]
    public required IReadOnlyList<Decrease> Decrease { get; init; }

    [JsonPropertyName("increase")]
    public required IReadOnlyList<Increase> Increase { get; init; }
}
