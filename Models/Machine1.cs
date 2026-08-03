using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Machine1
{
    [JsonPropertyName("machine")]
    public required Machine2 Machine { get; init; }

    [JsonPropertyName("version_group")]
    public required VersionGroup VersionGroup { get; init; }
}
