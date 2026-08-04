using System;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostTerminalSignatureRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature")]
    public string? Signature { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_id")]
    public Guid? TransactionId { get; init; }
}
