using System.Text.Json.Serialization;

namespace PokApi.Models;

public record AbilityFlavorText
{
    [JsonPropertyName("flavor_text")]
    public required string FlavorText { get; init; }

    [JsonPropertyName("language")]
    public required LanguageSummary Language { get; init; }

    [JsonPropertyName("version_group")]
    public required VersionGroupSummary VersionGroup { get; init; }
}
