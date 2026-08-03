using System.Collections.Generic;
using System.Text.Json.Serialization;
using PokApi.Core.Validation;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record PaginatedPokeathlonStatSummaryList
{
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next")]
    [Format(FormatKind.Uri)]
    public string? Next { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("previous")]
    [Format(FormatKind.Uri)]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public required IReadOnlyList<PokeathlonStatSummary> Results { get; init; }
}
