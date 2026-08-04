using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Models;

namespace StaxFattMerchantApi.Models;

public record PostTeamBrandingRequestBody
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("file")]
    public BinaryContent? File { get; init; }
}
