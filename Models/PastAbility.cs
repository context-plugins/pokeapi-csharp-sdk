using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PastAbility
{
    [JsonPropertyName("abilities")]
    public required IReadOnlyList<Ability> Abilities { get; init; }

    [JsonPropertyName("generation")]
    public required Generation Generation { get; init; }
}
