using System.Text.Json.Serialization;

namespace PokApi.Models;

public record TypeModel
{
    [JsonPropertyName("slot")]
    public required int Slot { get; init; }

    [JsonPropertyName("type")]
    public required Type1 Type { get; init; }
}
