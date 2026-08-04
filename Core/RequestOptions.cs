using Microsoft.Extensions.Logging;

namespace StaxFattMerchantApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
