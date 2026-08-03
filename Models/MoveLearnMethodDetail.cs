using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record MoveLearnMethodDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("name")]
    [MaxLength(200)]
    public required string Name { get; init; }

    [JsonPropertyName("names")]
    public required IReadOnlyList<MoveLearnMethodName> Names { get; init; }

    [JsonPropertyName("descriptions")]
    public required IReadOnlyList<MoveLearnMethodDescription> Descriptions { get; init; }

    [JsonPropertyName("version_groups")]
    public required IReadOnlyList<VersionGroup> VersionGroups { get; init; }
}
