using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Stat1
{
    [JsonPropertyName("base_stat")]
    public required int BaseStat { get; init; }

    [JsonPropertyName("effort")]
    public required int Effort { get; init; }

    [JsonPropertyName("stat")]
    public required Stat Stat { get; init; }
}
