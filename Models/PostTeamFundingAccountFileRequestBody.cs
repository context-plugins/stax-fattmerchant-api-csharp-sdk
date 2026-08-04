using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Models;

namespace StaxFattMerchantApi.Models;

public record PostTeamFundingAccountFileRequestBody
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("file")]
    public BinaryContent? File { get; init; }
}
