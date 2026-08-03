using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EffectChange
{
    [JsonPropertyName("effect_entries")]
    public required IReadOnlyList<EffectEntry2> EffectEntries { get; init; }

    [JsonPropertyName("version_group")]
    public required VersionGroup VersionGroup { get; init; }
}
