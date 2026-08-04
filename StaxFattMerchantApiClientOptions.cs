using StaxFattMerchantApi.Core.Configuration;
using StaxFattMerchantApi.Servers;

namespace StaxFattMerchantApi;

public class StaxFattMerchantApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public string? BearerAuth { get; set; }
}
