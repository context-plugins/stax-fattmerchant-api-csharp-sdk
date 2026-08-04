using StaxFattMerchantApi.Core.Authentication;
using StaxFattMerchantApi.Core.Authentication.Bearer;

namespace StaxFattMerchantApi;

internal sealed class AuthSchemes
{
    public IAuthScheme BearerAuth { get; }

    public AuthSchemes(StaxFattMerchantApiClientOptions options)
    {
        BearerAuth = BearerAuthScheme.Create(options.BearerAuth);
    }
}
