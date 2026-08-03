using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ItemPocketDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("categories")]
    public required IReadOnlyList<ItemCategorySummary> Categories { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<ItemPocketName> Names { get; init; }
}
