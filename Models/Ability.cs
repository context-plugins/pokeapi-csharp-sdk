using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Ability
{
    [JsonPropertyName("ability")]
    public required Ability1 AbilityValue { get; init; }

    [JsonPropertyName("is_hidden")]
    public required bool IsHidden { get; init; }

    [JsonPropertyName("slot")]
    public required int Slot { get; init; }
}
