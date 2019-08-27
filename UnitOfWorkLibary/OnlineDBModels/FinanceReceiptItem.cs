using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinanceReceiptItem
    {
        public int SysNo { get; set; }
        public int ReceiptSysNo { get; set; }
        public int FsincomeSysNo { get; set; }
        public decimal ReceiveAmt { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual FinanceReceipt ReceiptSysNoNavigation { get; set; }
    }
}
