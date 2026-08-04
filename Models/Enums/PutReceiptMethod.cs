using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Enum;

namespace StaxFattMerchantApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PutReceiptMethod>))]
public sealed record PutReceiptMethod : StringEnum<PutReceiptMethod>
{
    private PutReceiptMethod(string value) : base(value)
    {
    }

    public static readonly PutReceiptMethod Email = new("email");

    public static readonly PutReceiptMethod Sms = new("sms");

    public static PutReceiptMethod FromValue(string value) => FromValueCore(value);
}
