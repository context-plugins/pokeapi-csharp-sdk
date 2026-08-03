using System.Text.Json.Serialization;

namespace PokApi.Models;

public record StatChange
{
    [JsonPropertyName("change")]
    public required int Change { get; init; }

    [JsonPropertyName("stat")]
    public required Stat Stat { get; init; }
}
