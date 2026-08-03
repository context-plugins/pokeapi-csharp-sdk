using System.Text.Json.Serialization;
using PokApi.Core.Validation;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record PokemonSpecy
{
    /// <summary>
    /// Pokemon species name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The URL to get more information about the species
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public string? Url { get; init; }
}
