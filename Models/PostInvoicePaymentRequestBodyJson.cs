using System;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostInvoicePaymentRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_method_id")]
    public Guid? PaymentMethodId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apply_balance")]
    public bool? ApplyBalance { get; init; }
}
