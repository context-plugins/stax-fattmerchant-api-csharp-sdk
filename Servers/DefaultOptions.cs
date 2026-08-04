using StaxFattMerchantApi.Core.Models;

namespace StaxFattMerchantApi.Servers;

public class DefaultOptions
{
    public ProductionOptions Production { get; set; } = new();
    public Environment2Options Environment2 { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Production.BaseUrl, path, []),
            () => new UrlTemplate(Environment2.BaseUrl, path, []));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://apiprod.fattlabs.com";
    }

    public class Environment2Options
    {
        public string BaseUrl { get; set; } = "https://apidev.fattlabs.com";
    }
}
