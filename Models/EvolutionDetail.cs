using System.Text.Json.Serialization;

namespace PokApi.Models;

public record EvolutionDetail
{
    [JsonPropertyName("version_group")]
    public required VersionGroup VersionGroup { get; init; }

    [JsonPropertyName("is_default")]
    public required bool IsDefault { get; init; }

    [JsonPropertyName("gender")]
    public required Gender? Gender { get; init; }

    [JsonPropertyName("held_item")]
    public required HeldItem? HeldItem { get; init; }

    [JsonPropertyName("item")]
    public required Item? Item { get; init; }

    [JsonPropertyName("known_move")]
    public required object? KnownMove { get; init; }

    [JsonPropertyName("known_move_type")]
    public required object? KnownMoveType { get; init; }

    [JsonPropertyName("location")]
    public required Location? Location { get; init; }

    [JsonPropertyName("min_affection")]
    public required int? MinAffection { get; init; }

    [JsonPropertyName("min_beauty")]
    public required int? MinBeauty { get; init; }

    [JsonPropertyName("min_damage_taken")]
    public required int? MinDamageTaken { get; init; }

    [JsonPropertyName("min_happiness")]
    public required int? MinHappiness { get; init; }

    [JsonPropertyName("min_level")]
    public required int? MinLevel { get; init; }

    [JsonPropertyName("min_move_count")]
    public required int? MinMoveCount { get; init; }

    [JsonPropertyName("min_steps")]
    public required int? MinSteps { get; init; }

    [JsonPropertyName("near_special_rock")]
    public required bool? NearSpecialRock { get; init; }

    [JsonPropertyName("needs_multiplayer")]
    public required bool? NeedsMultiplayer { get; init; }

    [JsonPropertyName("needs_overworld_rain")]
    public required bool? NeedsOverworldRain { get; init; }

    [JsonPropertyName("party_species")]
    public required string? PartySpecies { get; init; }

    [JsonPropertyName("party_type")]
    public required string? PartyType { get; init; }

    [JsonPropertyName("relative_physical_stats")]
    public required string? RelativePhysicalStats { get; init; }

    [JsonPropertyName("time_of_day")]
    public required string TimeOfDay { get; init; }

    [JsonPropertyName("trade_species")]
    public required string? TradeSpecies { get; init; }

    [JsonPropertyName("trigger")]
    public required Trigger Trigger { get; init; }

    [JsonPropertyName("turn_upside_down")]
    public required bool TurnUpsideDown { get; init; }

    [JsonPropertyName("used_move")]
    public required object? UsedMove { get; init; }

    [JsonPropertyName("region")]
    public required Region? Region { get; init; }

    [JsonPropertyName("base_form")]
    public required BaseForm? BaseForm { get; init; }

    [JsonPropertyName("evolved_form")]
    public required EvolvedForm? EvolvedForm { get; init; }
}
