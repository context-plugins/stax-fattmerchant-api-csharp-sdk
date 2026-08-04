using System.Net.Http;

namespace StaxFattMerchantApi.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}