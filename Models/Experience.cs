using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record Experience
{
    [JsonPropertyName("level")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int Level { get; init; }

    [JsonPropertyName("experience")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int ExperienceValue { get; init; }
}
