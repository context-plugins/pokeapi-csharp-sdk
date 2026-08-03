using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Berry
{
    [JsonPropertyName("potency")]
    public required int Potency { get; init; }

    [JsonPropertyName("berry")]
    public required Berry1 BerryValue { get; init; }
}
