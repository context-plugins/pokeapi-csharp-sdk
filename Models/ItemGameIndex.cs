using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record ItemGameIndex
{
    [JsonPropertyName("game_index")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int GameIndex { get; init; }

    [JsonPropertyName("generation")]
    public required GenerationSummary Generation { get; init; }
}
