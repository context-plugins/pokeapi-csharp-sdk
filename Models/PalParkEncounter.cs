using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PalParkEncounter
{
    [JsonPropertyName("area")]
    public required Area Area { get; init; }

    [JsonPropertyName("base_score")]
    public required int BaseScore { get; init; }

    [JsonPropertyName("rate")]
    public required int Rate { get; init; }
}
