using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostSmsReceiptRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone")]
    public string? Phone { get; init; }
}
