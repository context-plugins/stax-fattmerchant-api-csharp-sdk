using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PutEmailReceiptRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }
}
