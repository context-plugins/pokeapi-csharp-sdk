using System.Text.Json.Serialization;

namespace PokApi.Models;

public record AwesomeName
{
    [JsonPropertyName("awesome_name")]
    public required string AwesomeNameValue { get; init; }

    [JsonPropertyName("language")]
    public required Language Language { get; init; }
}
