using System;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PutSetDefaultMerchantRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public Guid? MerchantId { get; init; }
}
