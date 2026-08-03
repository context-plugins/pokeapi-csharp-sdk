using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ItemCategoryDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("items")]
    public required IReadOnlyList<ItemSummary> Items { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<ItemCategoryName> Names { get; init; }

    [JsonPropertyName("pocket")]
    public required ItemPocketSummary Pocket { get; init; }
}
