using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SalesInvoiceGroupEtl
    {
        public int SysNo { get; set; }
        public int? InvoiceRequstType { get; set; }
        public int? Status { get; set; }
        public string InvoiceNo { get; set; }
        public decimal InvoiceAmt { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateTimeUserSysNo { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public int? LastUpdateUserSysNo { get; set; }
        public int IsMerge { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string BankInfo { get; set; }
        public string BankAccount { get; set; }
        public string TaxNum { get; set; }
        public string Remark { get; set; }
        public string InvoiceNumber { get; set; }
        public string DepartmentName { get; set; }
        public string CustomerGroup { get; set; }
        public int IsReconciliation { get; set; }
        public DateTime? VerificationTime { get; set; }
        public string ProductInvoiceType { get; set; }
        public string CustomerInvoiceRemark { get; set; }
        public string InvoiceReceiver { get; set; }
        public int InvoiceGroupSource { get; set; }
        public int BranchSysNo { get; set; }
    }
}
