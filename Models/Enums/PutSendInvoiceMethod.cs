using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Enum;

namespace StaxFattMerchantApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PutSendInvoiceMethod>))]
public sealed record PutSendInvoiceMethod : StringEnum<PutSendInvoiceMethod>
{
    private PutSendInvoiceMethod(string value) : base(value)
    {
    }

    public static readonly PutSendInvoiceMethod Email = new("email");

    public static readonly PutSendInvoiceMethod Sms = new("sms");

    public static PutSendInvoiceMethod FromValue(string value) => FromValueCore(value);
}
