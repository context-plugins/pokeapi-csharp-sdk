using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Flavor
{
    [JsonPropertyName("potency")]
    public required int Potency { get; init; }

    [JsonPropertyName("flavor")]
    public required Flavor1 FlavorValue { get; init; }
}
