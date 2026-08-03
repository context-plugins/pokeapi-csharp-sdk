using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record ContestTypeDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("berry_flavor")]
    public required BerryFlavorSummary BerryFlavor { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<ContestTypeName> Names { get; init; }
}
