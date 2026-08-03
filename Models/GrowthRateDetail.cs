using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record GrowthRateDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("formula")]
    [MaxLength(500)]
    public required string Formula { get; init; }

    [JsonPropertyName("descriptions")]
    public required IReadOnlyList<GrowthRateDescription> Descriptions { get; init; }

    [JsonPropertyName("levels")]
    public required IReadOnlyList<Experience> Levels { get; init; }

    [JsonPropertyName("pokemon_species")]
    public required IReadOnlyList<PokemonSpeciesSummary> PokemonSpecies { get; init; }
}
