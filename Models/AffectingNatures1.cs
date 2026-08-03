using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record AffectingNatures1
{
    [JsonPropertyName("increase")]
    public required IReadOnlyList<Increase2> Increase { get; init; }

    [JsonPropertyName("decrease")]
    public required IReadOnlyList<Decrease2> Decrease { get; init; }
}
