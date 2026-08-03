using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record BerryFlavorDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("berries")]
    public required IReadOnlyList<Berry> Berries { get; init; }

    [JsonPropertyName("contest_type")]
    public required ContestTypeSummary ContestType { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<BerryFlavorName> Names { get; init; }
}
