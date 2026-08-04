using System;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostPaymentMethodTokenRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public string? Token { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    public Guid? CustomerId { get; init; }
}
