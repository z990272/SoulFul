using ECPay.Payment.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class EcPayViewModel
    {
        public string HashKey { get; set; }
        public string HashIV { get; set; }
        public string MerchantID { get; set; }
        public string ReturnURL { get; set; }
        public string ClientBackURL { get; set; }
        public string OrderResultURL { get; set; }
        public string MerchantTradeNo { get; set; }
        public string MerchantTradeDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string TradeDesc { get; set; }
        public PaymentMethod ChoosePayment { get; set; }
        public string Remark { get; set; }
        public PaymentMethodItem ChooseSubPayment { get; set; }
        public ExtraPaymentInfo NeedExtraPaidInfo { get; set; }
        public DeviceType DeviceSource { get; set; }
        public string IgnorePayment { get; set; }
        public string PlatformID { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public int EncryptType { get; set; }
        public ItemCollection Items { get; set; }

    }

}                     