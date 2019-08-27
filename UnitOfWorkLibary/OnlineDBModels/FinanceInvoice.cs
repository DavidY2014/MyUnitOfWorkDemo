using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinanceInvoice
    {
        public int SysNo { get; set; }
        public string IinvoiceId { get; set; }
        public int CustomerSysNo { get; set; }
        public int FinanceReceiptSysNo { get; set; }
        public int Status { get; set; }
        public decimal ReceiveAmt { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AbandonUserSysNo { get; set; }
        public DateTime? AbandonTime { get; set; }
        public int? InvoiceType { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
