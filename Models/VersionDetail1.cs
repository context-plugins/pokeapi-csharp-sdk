using System.Text.Json.Serialization;

namespace PokApi.Models;

public record VersionDetail1
{
    [JsonPropertyName("rate")]
    public required int Rate { get; init; }

    [JsonPropertyName("version")]
    public required VersionModel Version { get; init; }
}
