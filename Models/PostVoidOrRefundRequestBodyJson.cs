using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PostVoidOrRefundRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public double? Total { get; init; }
}
