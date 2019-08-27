using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TreconciliationExpand
    {
        public int ReconciliationExpandId { get; set; }
        public int ReconciliationId { get; set; }
        public string IsSendBillMail { get; set; }
        public string Recipient { get; set; }
        public string RecipientMail { get; set; }
        public string InvoiceReceiverName { get; set; }
        public string InvoiceReceiverPhone { get; set; }
        public string InvoiceReceiverMobile { get; set; }
        public string InvoiceReceiverFax { get; set; }
        public string InvoiceReceiverAddress { get; set; }
        public string InvoiceReceiverMail { get; set; }
        public string BillFormat { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
