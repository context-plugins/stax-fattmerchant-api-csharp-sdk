using System;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostCreditRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_method_id")]
    public Guid? PaymentMethodId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public double? Total { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("meta")]
    public object? Meta { get; init; }
}
