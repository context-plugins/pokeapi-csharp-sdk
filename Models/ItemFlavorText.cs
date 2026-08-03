using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ItemFlavorText
{
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("version_group")]
    public required VersionGroupSummary VersionGroup { get; init; }

    [JsonPropertyName("language")]
    public required LanguageSummary Language { get; init; }
}
