using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record LocationDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("region")]
    public required RegionSummary Region { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<LocationName> Names { get; init; }

    [JsonPropertyName("game_indices")]
    public required IReadOnlyList<LocationGameIndex> GameIndices { get; init; }

    [JsonPropertyName("areas")]
    public required IReadOnlyList<LocationAreaSummary> Areas { get; init; }
}
