using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ContestCombos
{
    [JsonPropertyName("normal")]
    public required Normal Normal { get; init; }

    [JsonPropertyName("super")]
    public required Super Super { get; init; }
}
