using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Increase1
{
    [JsonPropertyName("change")]
    public required int Change { get; init; }

    [JsonPropertyName("move")]
    public required Move Move { get; init; }
}
