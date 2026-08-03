using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record PokemonShapeDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("awesome_names")]
    public required IReadOnlyList<AwesomeName> AwesomeNames { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<Name1> Names { get; init; }

    [JsonPropertyName("pokemon_species")]
    public required IReadOnlyList<PokemonSpeciesSummary> PokemonSpecies { get; init; }
}
