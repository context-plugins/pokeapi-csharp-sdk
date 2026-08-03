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
/// Evolution is a process in which a Pokémon changes into a different species of Pokémon.
/// </summary>
public sealed class Evolution
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Evolution(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// List evolution chains
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedEvolutionChainSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Evolution chains are essentially family trees. They start with the lowest stage within a family and detail evolution conditions for each as well as Pokémon they can evolve into up through the hierarchy.
    /// </remarks>
    public Task<PaginatedEvolutionChainSummaryList> EvolutionChainList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/evolution-chain/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedEvolutionChainSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get evolution chain
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EvolutionChainDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Evolution chains are essentially family trees. They start with the lowest stage within a family and detail evolution conditions for each as well as Pokémon they can evolve into up through the hierarchy.
    /// </remarks>
    public Task<EvolutionChainDetail> EvolutionChainRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/evolution-chain/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EvolutionChainDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List evolution triggers
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedEvolutionTriggerSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Evolution triggers are the events and conditions that cause a Pokémon to evolve. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Methods_of_evolution">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<PaginatedEvolutionTriggerSummaryList> EvolutionTriggerList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/evolution-trigger/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedEvolutionTriggerSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get evolution trigger
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EvolutionTriggerDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Evolution triggers are the events and conditions that cause a Pokémon to evolve. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Methods_of_evolution">Bulbapedia</see> for greater detail.
    /// </remarks>
    public Task<EvolutionTriggerDetail> EvolutionTriggerRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/evolution-trigger/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EvolutionTriggerDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
