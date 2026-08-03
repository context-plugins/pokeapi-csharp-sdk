using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record NatureBattleStylePreference
{
    [JsonPropertyName("low_hp_preference")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int LowHpPreference { get; init; }

    [JsonPropertyName("high_hp_preference")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public required int HighHpPreference { get; init; }

    [JsonPropertyName("move_battle_style")]
    public required MoveBattleStyleSummary MoveBattleStyle { get; init; }
}
