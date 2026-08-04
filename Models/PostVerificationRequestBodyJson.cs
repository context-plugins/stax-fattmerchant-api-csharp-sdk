using System;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostVerificationRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_method_id")]
    public Guid? PaymentMethodId { get; init; }
}
