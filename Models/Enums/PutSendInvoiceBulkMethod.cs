using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Enum;

namespace StaxFattMerchantApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PutSendInvoiceBulkMethod>))]
public sealed record PutSendInvoiceBulkMethod : StringEnum<PutSendInvoiceBulkMethod>
{
    private PutSendInvoiceBulkMethod(string value) : base(value)
    {
    }

    public static readonly PutSendInvoiceBulkMethod Email = new("email");

    public static readonly PutSendInvoiceBulkMethod Sms = new("sms");

    public static PutSendInvoiceBulkMethod FromValue(string value) => FromValueCore(value);
}
