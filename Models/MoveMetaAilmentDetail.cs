using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record MoveMetaAilmentDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("moves")]
    public required IReadOnlyList<Move> Moves { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<MoveMetaAilmentName> Names { get; init; }
}
