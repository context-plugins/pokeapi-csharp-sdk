using System.Text.Json.Serialization;
using PokApi.Core.Validation;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record Flavor1
{
    /// <summary>
    /// The name of the flavor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The URL to get more information about the flavor
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public string? Url { get; init; }
}
