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
/// Locations that can be visited within the games. Locations make up sizable portions of regions, like cities or routes.
/// </summary>
public sealed class LocationApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal LocationApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// List location areas
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedLocationAreaSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Location areas are sections of areas, such as floors in a building or cave. Each area has its own set of possible Pokémon encounters.
    /// </remarks>
    public Task<PaginatedLocationAreaSummaryList> LocationAreaList(int? limit,
        int? offset,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/location-area/"),
            [],
            [new Param("limit", limit), new Param("offset", offset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedLocationAreaSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get location area
    /// </summary>
    /// <param name="id">A unique integer value identifying this location area.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LocationAreaDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Location areas are sections of areas, such as floors in a building or cave. Each area has its own set of possible Pokémon encounters.
    /// </remarks>
    public Task<LocationAreaDetail> LocationAreaRetrieve(int id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/location-area/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<LocationAreaDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List locations
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedLocationSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Locations that can be visited within the games. Locations make up sizable portions of regions, like cities or routes.
    /// </remarks>
    public Task<PaginatedLocationSummaryList> LocationList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/location/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedLocationSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get location
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LocationDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Locations that can be visited within the games. Locations make up sizable portions of regions, like cities or routes.
    /// </remarks>
    public Task<LocationDetail> LocationRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/location/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<LocationDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List pal park areas
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedPalParkAreaSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Areas used for grouping Pokémon encounters in Pal Park. They're like habitats that are specific to Pal Park.
    /// </remarks>
    public Task<PaginatedPalParkAreaSummaryList> PalParkAreaList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/pal-park-area/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedPalParkAreaSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get pal park area
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PalParkAreaDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Areas used for grouping Pokémon encounters in Pal Park. They're like habitats that are specific to Pal Park.
    /// </remarks>
    public Task<PalParkAreaDetail> PalParkAreaRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/pal-park-area/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PalParkAreaDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List regions
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedRegionSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A region is an organized area of the Pokémon world. Most often, the main difference between regions is the species of Pokémon that can be encountered within them.
    /// </remarks>
    public Task<PaginatedRegionSummaryList> RegionList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/region/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedRegionSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get region
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RegionDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A region is an organized area of the Pokémon world. Most often, the main difference between regions is the species of Pokémon that can be encountered within them.
    /// </remarks>
    public Task<RegionDetail> RegionRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/region/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RegionDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
