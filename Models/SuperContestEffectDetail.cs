using System.Collections.Generic;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record SuperContestEffectDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("appeal")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int Appeal { get; init; }

    [JsonPropertyName("flavor_text_entries")]
    public required IReadOnlyList<SuperContestEffectFlavorText> FlavorTextEntries { get; init; }

    [JsonPropertyName("moves")]
    public required IReadOnlyList<MoveSummary> Moves { get; init; }
}
