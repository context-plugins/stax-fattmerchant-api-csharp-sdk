using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using StaxFattMerchantApi.Core.ErrorResponse;
using StaxFattMerchantApi.Core.Models;

namespace StaxFattMerchantApi.Errors;

public sealed class GetSelfError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetSelfError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetSelfError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static GetSelfError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetSelfError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSelfErrorResponse : IErrorResponse<GetSelfError>
{
    public static GetSelfErrorResponse Instance { get; } = new();

    private GetSelfErrorResponse()
    {
    }

    public Task<GetSelfError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetSelfError.Create(response, ct);
}
