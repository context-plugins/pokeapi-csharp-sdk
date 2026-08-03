using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record AbilityEffectText
{
    [JsonPropertyName("effect")]
    [MaxLength(6000)]
    public required string Effect { get; init; }

    [JsonPropertyName("short_effect")]
    [MaxLength(300)]
    public required string ShortEffect { get; init; }

    [JsonPropertyName("language")]
    public required LanguageSummary Language { get; init; }
}
