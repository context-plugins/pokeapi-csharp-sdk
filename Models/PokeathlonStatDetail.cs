using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokeathlonStatDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("affecting_natures")]
    public required AffectingNatures AffectingNatures { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<PokeathlonStatName> Names { get; init; }
}
