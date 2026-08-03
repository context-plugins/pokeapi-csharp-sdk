using System.Collections.Generic;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record ContestEffectDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("appeal")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int Appeal { get; init; }

    [JsonPropertyName("jam")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int Jam { get; init; }

    [JsonPropertyName("effect_entries")]
    public required IReadOnlyList<ContestEffectEffectText> EffectEntries { get; init; }

    [JsonPropertyName("flavor_text_entries")]
    public required IReadOnlyList<ContestEffectFlavorText> FlavorTextEntries { get; init; }
}
