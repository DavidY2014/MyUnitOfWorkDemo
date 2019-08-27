using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinanceInvoiceItem
    {
        public int SysNo { get; set; }
        public int IinvoiceId { get; set; }
        public int FsincomeSysNo { get; set; }
        public decimal ReceiveAmt { get; set; }
        public int InvoiceType { get; set; }
        public decimal InvoiceRatio { get; set; }
        public int Status { get; set; }
    }
}
