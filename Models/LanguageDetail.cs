using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record LanguageDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("official")]
    public bool? Official { get; init; }

    [JsonPropertyName("iso639")]
    [MaxLength(10)]
    public required string Iso639 { get; init; }

    [JsonPropertyName("iso3166")]
    [MaxLength(2)]
    public required string Iso3166 { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<LanguageName> Names { get; init; }
}
