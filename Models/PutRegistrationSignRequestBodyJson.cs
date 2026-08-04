using System.Text.Json.Serialization;

namespace StaxFattMerchantApi.Models;

public record PutRegistrationSignRequestBodyJson
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature")]
    public string? Signature { get; init; }
}
