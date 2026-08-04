using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PutTerminalSignatureRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature")]
    public string? Signature { get; init; }
}
