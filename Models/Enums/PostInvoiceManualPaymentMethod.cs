using System.Text.Json.Serialization;
using StaxFattMerchantApi.Core.Enum;

namespace StaxFattMerchantApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PostInvoiceManualPaymentMethod>))]
public sealed record PostInvoiceManualPaymentMethod : StringEnum<PostInvoiceManualPaymentMethod>
{
    private PostInvoiceManualPaymentMethod(string value) : base(value)
    {
    }

    public static readonly PostInvoiceManualPaymentMethod Cash = new("cash");

    public static readonly PostInvoiceManualPaymentMethod Check = new("check");

    public static readonly PostInvoiceManualPaymentMethod Giftcard = new("giftcard");

    public static readonly PostInvoiceManualPaymentMethod Paypal = new("paypal");

    public static readonly PostInvoiceManualPaymentMethod Venmo = new("venmo");

    public static readonly PostInvoiceManualPaymentMethod PaypalBnpl = new("paypal_bnpl");

    public static PostInvoiceManualPaymentMethod FromValue(string value) => FromValueCore(value);
}
