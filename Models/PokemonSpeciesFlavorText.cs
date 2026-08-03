using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokemonSpeciesFlavorText
{
    [JsonPropertyName("flavor_text")]
    public required string FlavorText { get; init; }

    [JsonPropertyName("language")]
    public required LanguageSummary Language { get; init; }

    [JsonPropertyName("version")]
    public required VersionSummary Version { get; init; }
}
