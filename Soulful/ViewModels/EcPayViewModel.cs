using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soulful.ViewModels
{
    public class EcPayViewModel
    {
        public string MerchantID { get; set; }
        public string MerchantTradeNo { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public string PaymentTypeChargeFee { get; set; }
        public string RtnCode { get; set; }
        public string RtnMsg { get; set; }
        public string SimulatePaid { get; set; }
        public string TradeAmt { get; set; }
        public string TradeDate { get; set; }
        public string TradeNo { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }

    }
}