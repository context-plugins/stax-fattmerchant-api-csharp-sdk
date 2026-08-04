using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record MergeCustomerRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duplicates")]
    public IReadOnlyList<Guid>? Duplicates { get; init; }
}
