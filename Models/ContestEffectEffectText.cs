using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ContestEffectEffectText
{
    [JsonPropertyName("effect")]
    [MaxLength(6000)]
    public required string Effect { get; init; }

    [JsonPropertyName("language")]
    public required LanguageSummary Language { get; init; }
}
