using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EvolutionTriggerDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<EvolutionTriggerName> Names { get; init; }

    [JsonPropertyName("pokemon_species")]
    public required IReadOnlyList<PokemonSpecy1> PokemonSpecies { get; init; }
}
