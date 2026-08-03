using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ItemFlingEffectDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("effect_entries")]
    public required IReadOnlyList<ItemFlingEffectEffectText> EffectEntries { get; init; }

    [JsonPropertyName("items")]
    public required IReadOnlyList<ItemSummary> Items { get; init; }
}
