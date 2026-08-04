using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PutSendInvoiceBulkRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoice_ids")]
    public IReadOnlyList<Guid>? InvoiceIds { get; init; }
}
