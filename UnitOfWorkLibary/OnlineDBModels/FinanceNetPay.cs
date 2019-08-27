using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinanceNetPay
    {
        public int SysNo { get; set; }
        public int SosysNo { get; set; }
        public int PayTypeSysNo { get; set; }
        public decimal PayAmount { get; set; }
        public int Source { get; set; }
        public DateTime InputTime { get; set; }
        public int? InputUserSysNo { get; set; }
        public int? ApproveUserSysNo { get; set; }
        public DateTime? ApproveTime { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public int? GssysNo { get; set; }
        public int? GcsysNo { get; set; }
        public int? NetPayOrderType { get; set; }
    }
}
