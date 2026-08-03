using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Pokemon5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("slot")]
    public int? Slot { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pokemon")]
    public Pokemon6? Pokemon { get; init; }
}
