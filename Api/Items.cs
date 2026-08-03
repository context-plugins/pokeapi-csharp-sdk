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
/// An item is an object in the games which the player can pick up, keep in their bag, and use in some manner. They have various uses, including healing, powering up, helping catch Pokémon, or to access a new area.
/// </summary>
public sealed class Items
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Items(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// List item attributes
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedItemAttributeSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Item attributes define particular aspects of items, e.g."usable in battle" or "consumable".
    /// </remarks>
    public Task<PaginatedItemAttributeSummaryList> ItemAttributeList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item-attribute/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedItemAttributeSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get item attribute
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemAttributeDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Item attributes define particular aspects of items, e.g."usable in battle" or "consumable".
    /// </remarks>
    public Task<ItemAttributeDetail> ItemAttributeRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item-attribute/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ItemAttributeDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List item categories
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedItemCategorySummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Item categories determine where items will be placed in the players bag.
    /// </remarks>
    public Task<PaginatedItemCategorySummaryList> ItemCategoryList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item-category/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedItemCategorySummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get item category
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemCategoryDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Item categories determine where items will be placed in the players bag.
    /// </remarks>
    public Task<ItemCategoryDetail> ItemCategoryRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item-category/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ItemCategoryDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List item fling effects
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedItemFlingEffectSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The various effects of the move"Fling" when used with different items.
    /// </remarks>
    public Task<PaginatedItemFlingEffectSummaryList> ItemFlingEffectList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item-fling-effect/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedItemFlingEffectSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get item fling effect
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemFlingEffectDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The various effects of the move"Fling" when used with different items.
    /// </remarks>
    public Task<ItemFlingEffectDetail> ItemFlingEffectRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item-fling-effect/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ItemFlingEffectDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List items
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedItemSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// An item is an object in the games which the player can pick up, keep in their bag, and use in some manner. They have various uses, including healing, powering up, helping catch Pokémon, or to access a new area.
    /// </remarks>
    public Task<PaginatedItemSummaryList> ItemList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedItemSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List item pockets
    /// </summary>
    /// <param name="limit">Number of results to return per page.</param>
    /// <param name="offset">The initial index from which to return the results.</param>
    /// <param name="q">&gt; Only available locally and not at <see href="https://pokeapi.co/docs/v2">pokeapi.co</see> Case-insensitive query applied on the <c>name</c> property.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedItemPocketSummaryList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Pockets within the players bag used for storing items by category.
    /// </remarks>
    public Task<PaginatedItemPocketSummaryList> ItemPocketList(int? limit,
        int? offset,
        string? q,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item-pocket/"),
            [],
            [new Param("limit", limit), new Param("offset", offset), new Param("q", q)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedItemPocketSummaryList>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get item pocket
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemPocketDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Pockets within the players bag used for storing items by category.
    /// </remarks>
    public Task<ItemPocketDetail> ItemPocketRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item-pocket/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ItemPocketDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get item
    /// </summary>
    /// <param name="id">This parameter can be a string or an integer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemDetail"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// An item is an object in the games which the player can pick up, keep in their bag, and use in some manner. They have various uses, including healing, powering up, helping catch Pokémon, or to access a new area.
    /// </remarks>
    public Task<ItemDetail> ItemRetrieve(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/api/v2/item/{id}/"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ItemDetail>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
