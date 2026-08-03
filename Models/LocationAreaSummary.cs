using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record LocationAreaSummary
{
    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public required string Url { get; init; }
}
