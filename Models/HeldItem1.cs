using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record HeldItem1
{
    [JsonPropertyName("item")]
    public required Item Item { get; init; }

    [JsonPropertyName("version_details")]
    public required IReadOnlyList<VersionDetail3> VersionDetails { get; init; }
}
