using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerVatinfo
    {
        public int SysNo { get; set; }
        public int? CustomerSysNo { get; set; }
        public string CompanyName { get; set; }
        public string TaxNum { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string BankInfo { get; set; }
        public string BankAccount { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Memo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? IsDefault { get; set; }
        public int? Status { get; set; }
        public int? AddressSysNo { get; set; }
        public int? InvoiceType { get; set; }
        public int? CustomerDepartmentId { get; set; }
        public int? CompanySysNo { get; set; }
    }
}
