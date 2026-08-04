using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record DeleteItemBulkRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ids")]
    public IReadOnlyList<Guid>? Ids { get; init; }
}
