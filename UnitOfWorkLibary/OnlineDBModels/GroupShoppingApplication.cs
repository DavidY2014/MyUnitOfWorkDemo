using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class GroupShoppingApplication
    {
        public int SysNo { get; set; }
        public string Gsid { get; set; }
        public int CustomerSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int GssysNo { get; set; }
        public decimal Gsprice { get; set; }
        public int Gsqty { get; set; }
        public decimal Gsamt { get; set; }
        public int PayTypeSysNo { get; set; }
        public decimal PayPrice { get; set; }
        public int ShipTypeSysNo { get; set; }
        public decimal ShipPrice { get; set; }
        public int PayStatus { get; set; }
        public int Status { get; set; }
        public int ReceiveAreaSysNo { get; set; }
        public string ReceiveContact { get; set; }
        public string ReceivePhone { get; set; }
        public string ReceiveCellPhone { get; set; }
        public string ReceivePasphone { get; set; }
        public string ReceiveAddress { get; set; }
        public string ReceiveZip { get; set; }
        public int? InvoiceType { get; set; }
        public string InvoiceName { get; set; }
        public string CompanyName { get; set; }
        public string TaxNum { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string BankAccount { get; set; }
        public string Memo { get; set; }
        public DateTime? SocreateTime { get; set; }
        public int? SosysNo { get; set; }
        public string AliPayTradeNo { get; set; }
        public int? AbandonUserSysNo { get; set; }
        public DateTime? AbandonTime { get; set; }
        public int? ReturnPayUserSysNo { get; set; }
        public DateTime? ReturnPayTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public int DistributionRequireType { get; set; }
        public string Sonote { get; set; }
        public string Email { get; set; }
        public int? Sex { get; set; }
    }
}
