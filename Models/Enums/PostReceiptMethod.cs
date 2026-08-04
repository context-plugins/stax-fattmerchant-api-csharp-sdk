using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Enum;

namespace StaxFattMerchantApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PostReceiptMethod>))]
public sealed record PostReceiptMethod : StringEnum<PostReceiptMethod>
{
    private PostReceiptMethod(string value) : base(value)
    {
    }

    public static readonly PostReceiptMethod Email = new("email");

    public static readonly PostReceiptMethod Sms = new("sms");

    public static PostReceiptMethod FromValue(string value) => FromValueCore(value);
}
