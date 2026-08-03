using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record PokemonSpeciesDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Order { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gender_rate")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? GenderRate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capture_rate")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? CaptureRate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_happiness")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? BaseHappiness { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_baby")]
    public bool? IsBaby { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_legendary")]
    public bool? IsLegendary { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_mythical")]
    public bool? IsMythical { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hatch_counter")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? HatchCounter { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_gender_differences")]
    public bool? HasGenderDifferences { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forms_switchable")]
    public bool? FormsSwitchable { get; init; }

    [JsonPropertyName("growth_rate")]
    public required GrowthRateSummary GrowthRate { get; init; }

    [JsonPropertyName("pokedex_numbers")]
    public required IReadOnlyList<PokemonDexEntry> PokedexNumbers { get; init; }

    [JsonPropertyName("egg_groups")]
    public required IReadOnlyList<EggGroup> EggGroups { get; init; }

    [JsonPropertyName("color")]
    public required PokemonColorSummary Color { get; init; }

    [JsonPropertyName("shape")]
    public required PokemonShapeSummary Shape { get; init; }

    [JsonPropertyName("evolves_from_species")]
    public required PokemonSpeciesSummary EvolvesFromSpecies { get; init; }

    [JsonPropertyName("evolution_chain")]
    public required EvolutionChainSummary EvolutionChain { get; init; }

    [JsonPropertyName("habitat")]
    public required PokemonHabitatSummary Habitat { get; init; }

    [JsonPropertyName("generation")]
    public required GenerationSummary Generation { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<Name> Names { get; init; }

    [JsonPropertyName("pal_park_encounters")]
    public required IReadOnlyList<PalParkEncounter> PalParkEncounters { get; init; }

    [JsonPropertyName("form_descriptions")]
    public required IReadOnlyList<PokemonSpeciesDescription> FormDescriptions { get; init; }

    [JsonPropertyName("flavor_text_entries")]
    public required IReadOnlyList<PokemonSpeciesFlavorText> FlavorTextEntries { get; init; }

    [JsonPropertyName("genera")]
    public required IReadOnlyList<Genera> Genera { get; init; }

    [JsonPropertyName("varieties")]
    public required IReadOnlyList<Variety> Varieties { get; init; }
}
