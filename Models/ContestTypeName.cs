using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ContestTypeName
{
    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("color")]
    [MaxLength(10)]
    public required string Color { get; init; }

    [JsonPropertyName("language")]
    public required LanguageSummary Language { get; init; }
}
