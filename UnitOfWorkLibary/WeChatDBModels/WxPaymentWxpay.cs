using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxPaymentWxpay
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string PartnerId { get; set; }
        public string AppId { get; set; }
        public string PartnerKey { get; set; }
        public string PaySignKey { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CertInfoPath { get; set; }
        public string PartnerPwd { get; set; }
        public string ShName { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string Remark { get; set; }
        public bool? QuicklyFh { get; set; }
    }
}
