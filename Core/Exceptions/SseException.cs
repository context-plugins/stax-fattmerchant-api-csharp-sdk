using System;

namespace StaxFattMerchantApi.Core.Exceptions;

public abstract class SseException : Exception
{
    private protected SseException(string message) : base(message)
    {
    }

    private protected SseException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
