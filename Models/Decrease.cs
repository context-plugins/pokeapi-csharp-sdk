using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record Decrease
{
    [JsonPropertyName("max_change")]
    [Maximum(-1)]
    public required int MaxChange { get; init; }

    [JsonPropertyName("nature")]
    public required Nature Nature { get; init; }
}
