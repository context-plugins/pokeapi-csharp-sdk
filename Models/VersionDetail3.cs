using System.Text.Json.Serialization;

namespace PokApi.Models;

public record VersionDetail3
{
    [JsonPropertyName("rarity")]
    public required int Rarity { get; init; }

    [JsonPropertyName("version")]
    public required VersionModel Version { get; init; }
}
