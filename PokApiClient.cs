using System.Net.Http;
using PokApi.Api;
using PokApi.Core;
using PokApi.Core.Logging;
using PokApi.Core.Models;

namespace PokApi;

/// <summary>
/// All the Pokémon data you'll ever need in one place, easily accessible through a modern free open-source RESTful API.
/// <para>
/// ## What is this?
/// </para>
/// <para>
/// This is a full RESTful API linked to an extensive database detailing everything about the Pokémon main game series.
/// </para>
/// <para>
/// We've covered everything from Pokémon to Berry Flavors.
/// </para>
/// <para>
/// ## Where do I start?
/// </para>
/// <para>
/// We have awesome <see href="https://pokeapi.co/docs/v2">documentation</see> on how to use this API. It takes minutes to get started.
/// </para>
/// <para>
/// This API will always be publicly available and will never require any extensive setup process to consume.
/// </para>
/// <para>
/// Created by <see href="https://github.com/phalt"><b>Paul Hallett</b></see> and other <see href="https://github.com/PokeAPI/pokeapi#contributing"><b>PokéAPI contributors</b></see> around the world. Pokémon and Pokémon character names are trademarks of Nintendo.
/// </para>
/// </summary>
public sealed class PokApiClient
{
    public PokApiClient(HttpClient httpClient, PokApiClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "PokApiClient/2.10.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "2.10.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "PokApiClient");
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        Berries = new Berries(rawClient, server);
        Contests = new Contests(rawClient, server);
        Encounters = new Encounters(rawClient, server);
        Evolution = new Evolution(rawClient, server);
        Games = new Games(rawClient, server);
        Items = new Items(rawClient, server);
        LocationApi = new LocationApi(rawClient, server);
        Machines = new Machines(rawClient, server);
        Moves = new Moves(rawClient, server);
        PokemonApi = new PokemonApi(rawClient, server);
        Utility = new Utility(rawClient, server);
    }

    /// <summary>
    /// Berries can be soft or hard. Check out <see href="http://bulbapedia.bulbagarden.net/wiki/Category:Berries_by_firmness">Bulbapedia</see> for greater detail.
    /// </summary>
    public Berries Berries { get; }

    public Contests Contests { get; }

    public Encounters Encounters { get; }

    /// <summary>
    /// Evolution is a process in which a Pokémon changes into a different species of Pokémon.
    /// </summary>
    public Evolution Evolution { get; }

    /// <summary>
    /// The Pokémon games are all video games in the Pokémon franchise.
    /// </summary>
    public Games Games { get; }

    /// <summary>
    /// An item is an object in the games which the player can pick up, keep in their bag, and use in some manner. They have various uses, including healing, powering up, helping catch Pokémon, or to access a new area.
    /// </summary>
    public Items Items { get; }

    /// <summary>
    /// Locations that can be visited within the games. Locations make up sizable portions of regions, like cities or routes.
    /// </summary>
    public LocationApi LocationApi { get; }

    /// <summary>
    /// Machines are the representation of items that teach moves to Pokémon. They vary from version to version, so it is not certain that one specific TM or HM corresponds to a single Machine.
    /// </summary>
    public Machines Machines { get; }

    /// <summary>
    /// Moves are the skills of Pokémon in battle. In battle, a Pokémon uses one move each turn. Some moves (including those learned by Hidden Machine) can be used outside of battle as well, usually for the purpose of removing obstacles or exploring new areas.
    /// </summary>
    public Moves Moves { get; }

    /// <summary>
    /// Pokémon are the creatures that inhabit the world of the Pokémon games. They can be caught using Pokéballs and trained by battling with other Pokémon. Each Pokémon belongs to a specific species but may take on a variant which makes it differ from other Pokémon of the same species, such as base stats, available abilities and typings. See <see href="http://bulbapedia.bulbagarden.net/wiki/Pok%C3%A9mon_(species">Bulbapedia</see>) for greater detail.
    /// </summary>
    public PokemonApi PokemonApi { get; }

    public Utility Utility { get; }
}
