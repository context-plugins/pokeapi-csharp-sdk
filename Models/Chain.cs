using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Chain
{
    [JsonPropertyName("evolution_details")]
    public required IReadOnlyList<object> EvolutionDetails { get; init; }

    [JsonPropertyName("evolves_to")]
    public required IReadOnlyList<EvolvesTo> EvolvesTo { get; init; }

    [JsonPropertyName("is_baby")]
    public required bool IsBaby { get; init; }

    [JsonPropertyName("species")]
    public required Species Species { get; init; }
}
