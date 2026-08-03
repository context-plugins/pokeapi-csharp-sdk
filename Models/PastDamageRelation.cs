using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PastDamageRelation
{
    [JsonPropertyName("generation")]
    public required Generation Generation { get; init; }

    [JsonPropertyName("damage_relations")]
    public required DamageRelations DamageRelations { get; init; }
}
