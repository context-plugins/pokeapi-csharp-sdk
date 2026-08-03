using System.Text.Json.Serialization;
using PokApi.Core.Validation;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record Cries
{
    [JsonPropertyName("latest")]
    [Format(FormatKind.Uri)]
    public required string Latest { get; init; }

    [JsonPropertyName("legacy")]
    [Format(FormatKind.Uri)]
    public required string Legacy { get; init; }
}
