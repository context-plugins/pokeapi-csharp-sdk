using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokemonSpeciesDescription
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(2000)]
    public string? Description { get; init; }

    [JsonPropertyName("language")]
    public required LanguageSummary Language { get; init; }
}
