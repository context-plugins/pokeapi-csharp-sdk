using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PastStat
{
    [JsonPropertyName("generation")]
    public required Generation Generation { get; init; }

    [JsonPropertyName("stats")]
    public required IReadOnlyList<Stat1> Stats { get; init; }
}
