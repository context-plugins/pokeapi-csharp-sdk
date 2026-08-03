using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EvolutionChainDetail
{
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    [JsonPropertyName("baby_trigger_item")]
    public required ItemSummary BabyTriggerItem { get; init; }

    [JsonPropertyName("chain")]
    public required Chain Chain { get; init; }
}
