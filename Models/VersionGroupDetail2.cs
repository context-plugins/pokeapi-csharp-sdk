using System.Text.Json.Serialization;

namespace PokApi.Models;

public record VersionGroupDetail2
{
    [JsonPropertyName("level_learned_at")]
    public required int LevelLearnedAt { get; init; }

    [JsonPropertyName("move_learn_method")]
    public required MoveLearnMethod MoveLearnMethod { get; init; }

    [JsonPropertyName("version_group")]
    public required VersionGroup VersionGroup { get; init; }
}
