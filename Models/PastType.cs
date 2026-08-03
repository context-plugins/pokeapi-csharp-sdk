using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PastType
{
    [JsonPropertyName("generation")]
    public required Generation Generation { get; init; }

    [JsonPropertyName("types")]
    public required IReadOnlyList<TypeModel> Types { get; init; }
}
