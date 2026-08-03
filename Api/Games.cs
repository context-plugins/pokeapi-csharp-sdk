using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using PokApi.Core;
using PokApi.Core.ErrorResponse;
using PokApi.Core.Exceptions;
using PokApi.Core.Models;
using PokApi.Core.Request;
using PokApi.Core.Response;
using PokApi.Models;

namespace PokApi.Api;

/// <summary>
/// The Pokémon games are all video games in the Pokémon franchise.
/// </summary>
public sealed class Games
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Games(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// List genrations
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedGenerationSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A generation is a grouping of the Pokémon games that separates them based on the Pokémon they include. In each generation, a new set of Pokémon, Moves, Abilities and Types that did not exist in the previous generation are released.
    /// </remarks>
    public Task<PaginatedGenerationSummaryList> GenerationList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/generation/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedGenerationSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get genration
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenerationDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A generation is a grouping of the Pokémon games that separates them based on the Pokémon they include. In each generation, a new set of Pokémon, Moves, Abilities and Types that did not exist in the previous generation are released.
    /// </remarks>
    public Task<GenerationDetail> GenerationRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/generation/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GenerationDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List pokedex
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedPokedexSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A Pokédex is a handheld electronic encyclopedia device; one which is capable of recording and retaining information of the various Pokémon in a given region with the exception of the national dex and some smaller dexes related to portions of a region. See <see href="http://bulbapedia.bulbagarden.net/wiki/Pokedex">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<PaginatedPokedexSummaryList> PokedexList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/pokedex/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedPokedexSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get pokedex
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PokedexDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A Pokédex is a handheld electronic encyclopedia device; one which is capable of recording and retaining information of the various Pokémon in a given region with the exception of the national dex and some smaller dexes related to portions of a region. See <see href="http://bulbapedia.bulbagarden.net/wiki/Pokedex">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<PokedexDetail> PokedexRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/pokedex/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PokedexDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List version groups
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedVersionGroupSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Version groups categorize highly similar versions of the games.
    /// </remarks>
    public Task<PaginatedVersionGroupSummaryList> VersionGroupList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/version-group/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedVersionGroupSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get version group
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VersionGroupDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Version groups categorize highly similar versions of the games.
    /// </remarks>
    public Task<VersionGroupDetail> VersionGroupRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/version-group/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VersionGroupDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List versions
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedVersionSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Versions of the games, e.g., Red, Blue or Yellow.
    /// </remarks>
    public Task<PaginatedVersionSummaryList> VersionList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/version/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedVersionSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get version
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VersionDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Versions of the games, e.g., Red, Blue or Yellow.
    /// </remarks>
    public Task<VersionDetail> VersionRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/version/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<VersionDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
