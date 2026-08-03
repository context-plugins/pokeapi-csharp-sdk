using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record DamageRelations
{
    [JsonPropertyName("no_damage_to")]
    public required IReadOnlyList<NoDamageTo> NoDamageTo { get; init; }

    [JsonPropertyName("half_damage_to")]
    public required IReadOnlyList<HalfDamageTo> HalfDamageTo { get; init; }

    [JsonPropertyName("double_damage_to")]
    public required IReadOnlyList<DoubleDamageTo> DoubleDamageTo { get; init; }

    [JsonPropertyName("no_damage_from")]
    public required IReadOnlyList<NoDamageFrom> NoDamageFrom { get; init; }

    [JsonPropertyName("half_damage_from")]
    public required IReadOnlyList<HalfDamageFrom> HalfDamageFrom { get; init; }

    [JsonPropertyName("double_damage_from")]
    public required IReadOnlyList<DoubleDamageFrom> DoubleDamageFrom { get; init; }
}
