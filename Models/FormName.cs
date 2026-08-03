using System.Text.Json.Serialization;

namespace PokApi.Models;

public record FormName
{
    [JsonPropertyName("language")]
    public required Language Language { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
