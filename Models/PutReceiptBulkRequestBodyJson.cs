using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PutReceiptBulkRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_ids")]
    public IReadOnlyList<Guid>? TransactionIds { get; init; }
}
