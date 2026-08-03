using System.Text.Json.Serialization;
using PokApi.Core.Validation;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record Sprites
{
    [JsonPropertyName("default")]
    [Format(FormatKind.Uri)]
    public required string Default { get; init; }
}
