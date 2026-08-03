using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record BerryFirmnessDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("berries")]
    public required IReadOnlyList<BerrySummary> Berries { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<BerryFirmnessName> Names { get; init; }
}
