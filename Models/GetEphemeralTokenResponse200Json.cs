using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record GetEphemeralTokenResponse200Json
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public string? Token { get; init; }
}
