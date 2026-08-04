using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Models;

namespace StaxFattMerchantApi.Models;

public record PostFileRequestBody
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("file")]
    public BinaryContent? File { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tag")]
    public string? Tag { get; init; }
}
