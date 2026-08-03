using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PokApi.Models;

public record CharacteristicDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("gene_modulo")]
    public required int GeneModulo { get; init; }

    [JsonPropertyName("possible_values")]
    public required IReadOnlyList<int> PossibleValues { get; init; }

    [JsonPropertyName("highest_stat")]
    public required StatSummary HighestStat { get; init; }

    [JsonPropertyName("descriptions")]
    public required IReadOnlyList<CharacteristicDescription> Descriptions { get; init; }
}
