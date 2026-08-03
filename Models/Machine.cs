using System.Text.Json.Serialization;
using PokApi.Core.Validation;
using PokApi.Core.Validation.Attributes;

namespace PokApi.Models;

public record Machine
{
    [JsonPropertyName("machine")]
    [Format(FormatKind.Uri)]
    public required string MachineValue { get; init; }

    [JsonPropertyName("version_group")]
    public required VersionGroup VersionGroup { get; init; }
}
