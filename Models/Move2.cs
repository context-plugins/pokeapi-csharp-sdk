using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record Move2
{
    [JsonPropertyName("move")]
    public required Move Move { get; init; }

    [JsonPropertyName("version_group_details")]
    public required IReadOnlyList<VersionGroupDetail2> VersionGroupDetails { get; init; }
}
