using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record AbilityDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_main_series")]
    public bool? IsMainSeries { get; init; }

    [JsonPropertyName("generation")]
    public required GenerationSummary Generation { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<AbilityName> Names { get; init; }

    [JsonPropertyName("effect_entries")]
    public required IReadOnlyList<AbilityEffectText> EffectEntries { get; init; }

    [JsonPropertyName("effect_changes")]
    public required IReadOnlyList<AbilityChange> EffectChanges { get; init; }

    [JsonPropertyName("flavor_text_entries")]
    public required IReadOnlyList<AbilityFlavorText> FlavorTextEntries { get; init; }

    [JsonPropertyName("pokemon")]
    public required IReadOnlyList<Pokemon> Pokemon { get; init; }
}
