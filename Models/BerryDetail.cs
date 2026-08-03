using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record BerryDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("growth_time")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? GrowthTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_harvest")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? MaxHarvest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("natural_gift_power")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? NaturalGiftPower { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("size")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Size { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smoothness")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? Smoothness { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("soil_dryness")]
    [Minimum(-2147483648)]
    [Maximum(2147483647)]
    public int? SoilDryness { get; init; }

    [JsonPropertyName("firmness")]
    public required BerryFirmnessSummary Firmness { get; init; }

    [JsonPropertyName("flavors")]
    public required IReadOnlyList<Flavor> Flavors { get; init; }

    [JsonPropertyName("item")]
    public required ItemSummary Item { get; init; }

    [JsonPropertyName("natural_gift_type")]
    public required TypeSummary NaturalGiftType { get; init; }
}
