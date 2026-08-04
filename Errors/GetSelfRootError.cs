using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using StaxFattMerchantApi.Core.ErrorResponse;
using StaxFattMerchantApi.Core.Models;

namespace StaxFattMerchantApi.Errors;

public sealed class GetSelfRootError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private GetSelfRootError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static GetSelfRootError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static GetSelfRootError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetSelfRootError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetSelfRootErrorResponse : IErrorResponse<GetSelfRootError>
{
    public static GetSelfRootErrorResponse Instance { get; } = new();

    private GetSelfRootErrorResponse()
    {
    }

    public Task<GetSelfRootError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetSelfRootError.Create(response, ct);
}
