using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record AffectingMoves
{
    [JsonPropertyName("increase")]
    public required IReadOnlyList<Increase1> Increase { get; init; }

    [JsonPropertyName("decrease")]
    public required IReadOnlyList<Decrease1> Decrease { get; init; }
}
