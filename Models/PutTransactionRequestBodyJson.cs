using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PutTransactionRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("meta")]
    public object? Meta { get; init; }
}
