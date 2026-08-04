using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Enum;

namespace StaxFattMerchantApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PutReceiptBulkMethodMethod>))]
public sealed record PutReceiptBulkMethodMethod : StringEnum<PutReceiptBulkMethodMethod>
{
    private PutReceiptBulkMethodMethod(string value) : base(value)
    {
    }

    public static readonly PutReceiptBulkMethodMethod Email = new("email");

    public static readonly PutReceiptBulkMethodMethod Sms = new("sms");

    public static PutReceiptBulkMethodMethod FromValue(string value) => FromValueCore(value);
}
