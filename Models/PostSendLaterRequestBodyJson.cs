using System;
using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostSendLaterRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("send_at")]
    public DateTimeOffset? SendAt { get; init; }
}
