using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PutSmsReceiptRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public string? Phone { get; init; }
}
