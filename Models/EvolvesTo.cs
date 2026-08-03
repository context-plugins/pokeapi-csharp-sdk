using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EvolvesTo
{
    [JsonPropertyName("evolution_details")]
    public required IReadOnlyList<EvolutionDetail> EvolutionDetails { get; init; }

    [JsonPropertyName("is_baby")]
    public required bool IsBaby { get; init; }

    [JsonPropertyName("species")]
    public required Species Species { get; init; }
}
