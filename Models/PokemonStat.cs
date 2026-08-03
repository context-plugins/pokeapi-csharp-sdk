using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record PokemonStat
{
    [JsonPropertyName("base_stat")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int BaseStat { get; init; }

    [JsonPropertyName("effort")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int Effort { get; init; }

    [JsonPropertyName("stat")]
    public required StatSummary Stat { get; init; }
}
