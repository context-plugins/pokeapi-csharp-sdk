using System.Text.Json.Serialization;

namespace PokApi.Models;

public record MachineDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("item")]
    public required ItemSummary Item { get; init; }

    [JsonPropertyName("version_group")]
    public required VersionGroupSummary VersionGroup { get; init; }

    [JsonPropertyName("move")]
    public required MoveSummary Move { get; init; }
}
