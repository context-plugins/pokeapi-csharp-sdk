using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Normal
{
    [JsonPropertyName("use_before")]
    public required IReadOnlyList<UseBefore?> UseBefore { get; init; }

    [JsonPropertyName("use_after")]
    public required IReadOnlyList<UseAfter?> UseAfter { get; init; }
}
