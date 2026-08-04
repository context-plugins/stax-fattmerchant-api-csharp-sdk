using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostRefundRequestBodyJson
{
    /// <summary>
    /// Partial refund amount (omit for full refund)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public double? Total { get; init; }
}
