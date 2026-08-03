using System.Text.Json.Serialization;
using PokApi.Core.Validation;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record Sprites2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("default")]
    [Format(FormatKind.Uri)]
    public string? Default { get; init; }
}
