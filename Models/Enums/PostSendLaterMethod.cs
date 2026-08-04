using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Enum;

namespace StaxFattMerchantApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PostSendLaterMethod>))]
public sealed record PostSendLaterMethod : StringEnum<PostSendLaterMethod>
{
    private PostSendLaterMethod(string value) : base(value)
    {
    }

    public static readonly PostSendLaterMethod Email = new("email");

    public static readonly PostSendLaterMethod Sms = new("sms");

    public static PostSendLaterMethod FromValue(string value) => FromValueCore(value);
}
