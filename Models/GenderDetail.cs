using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record GenderDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("pokemon_species_details")]
    public required IReadOnlyList<PokemonSpeciesDetail2> PokemonSpeciesDetails { get; init; }

    [JsonPropertyName("required_for_evolution")]
    public required IReadOnlyList<RequiredForEvolution> RequiredForEvolution { get; init; }
}
