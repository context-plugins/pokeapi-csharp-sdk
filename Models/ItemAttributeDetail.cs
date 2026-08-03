using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ItemAttributeDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("descriptions")]
    public required IReadOnlyList<ItemAttributeDescription> Descriptions { get; init; }

    [JsonPropertyName("items")]
    public required IReadOnlyList<Item> Items { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<ItemAttributeName> Names { get; init; }
}
