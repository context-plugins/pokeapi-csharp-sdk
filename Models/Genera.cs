using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Genera
{
    [JsonPropertyName("genus")]
    public required string Genus { get; init; }

    [JsonPropertyName("language")]
    public required Language Language { get; init; }
}
