using Microsoft.Extensions.Logging;

namespace PokApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
