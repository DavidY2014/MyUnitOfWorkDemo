using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinanceReceipt
    {
        public FinanceReceipt()
        {
            FinanceReceiptItem = new HashSet<FinanceReceiptItem>();
        }

        public int SysNo { get; set; }
        public string ReceiptId { get; set; }
        public int CustomerSysNo { get; set; }
        public int Status { get; set; }
        public decimal ReceiveAmt { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? ConfirmUserSysNo { get; set; }
        public DateTime? ConfirmTime { get; set; }
        public int? AbandonUserSysNo { get; set; }
        public DateTime? AbandonTime { get; set; }

        public virtual ICollection<FinanceReceiptItem> FinanceReceiptItem { get; set; }
    }
}
