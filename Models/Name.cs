using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Name
{
    [JsonPropertyName("language")]
    public required Language Language { get; init; }

    [JsonPropertyName("name")]
    public required string NameValue { get; init; }
}
