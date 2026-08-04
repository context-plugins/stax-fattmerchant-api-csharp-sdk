using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostCacheTestRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }
}
