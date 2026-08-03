using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record SuperContestEffectFlavorText
{
    [JsonPropertyName("flavor_text")]
    [MaxLength(500)]
    public required string FlavorText { get; init; }

    [JsonPropertyName("language")]
    public required LanguageSummary Language { get; init; }
}
