using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record MoveTargetDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("descriptions")]
    public required IReadOnlyList<MoveTargetDescription> Descriptions { get; init; }

    [JsonPropertyName("moves")]
    public required IReadOnlyList<MoveSummary> Moves { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<MoveTargetName> Names { get; init; }
}
