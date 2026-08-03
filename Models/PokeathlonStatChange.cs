using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokeathlonStatChange
{
    [JsonPropertyName("max_change")]
    public required int MaxChange { get; init; }

    [JsonPropertyName("pokeathlon_stat")]
    public required PokeathlonStat PokeathlonStat { get; init; }
}
