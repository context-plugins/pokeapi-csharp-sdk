using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record AbilityChange
{
    [JsonPropertyName("version_group")]
    public required VersionGroupSummary VersionGroup { get; init; }

    [JsonPropertyName("effect_entries")]
    public required IReadOnlyList<AbilityChangeEffectText> EffectEntries { get; init; }
}
