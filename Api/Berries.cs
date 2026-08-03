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
/// Berries can be soft or hard. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Category:Berries_by_firmness">Bulbapedia</see> for greater detail.
/// </summary>
public sealed class Berries
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Berries(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// List berry firmness
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedBerryFirmnessSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Berries can be soft or hard. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Category:Berries_by_firmness">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<PaginatedBerryFirmnessSummaryList> BerryFirmnessList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/berry-firmness/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedBerryFirmnessSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get berry by firmness
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BerryFirmnessDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Berries can be soft or hard. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Category:Berries_by_firmness">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<BerryFirmnessDetail> BerryFirmnessRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/berry-firmness/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BerryFirmnessDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List berry flavors
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedBerryFlavorSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Flavors determine whether a Pokémon will benefit or suffer from eating a berry based on their <b>nature</b>. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Flavor">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<PaginatedBerryFlavorSummaryList> BerryFlavorList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/berry-flavor/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedBerryFlavorSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get berries by flavor
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BerryFlavorDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Flavors determine whether a Pokémon will benefit or suffer from eating a berry based on their <b>nature</b>. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Flavor">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<BerryFlavorDetail> BerryFlavorRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/berry-flavor/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BerryFlavorDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List berries
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedBerrySummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Berries are small fruits that can provide HP and status condition restoration, stat enhancement, and even damage negation when eaten by Pokémon. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Berry">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<PaginatedBerrySummaryList> BerryList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/berry/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedBerrySummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a berry
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BerryDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Berries are small fruits that can provide HP and status condition restoration, stat enhancement, and even damage negation when eaten by Pokémon. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Berry">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<BerryDetail> BerryRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/berry/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BerryDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
