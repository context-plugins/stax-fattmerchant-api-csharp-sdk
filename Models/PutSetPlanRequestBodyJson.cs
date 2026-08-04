using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PutSetPlanRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan")]
    public string? Plan { get; init; }
}
