using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinancePopayItemTd
    {
        public int SysNo { get; set; }
        public int PosysNo { get; set; }
        public int PayStyle { get; set; }
        public decimal PayAmt { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? EstimatePayTime { get; set; }
        public string ReferenceId { get; set; }
        public DateTime? PayTime { get; set; }
        public int? PayUserSysNo { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public int? IsPrintPopayBill { get; set; }
        public int? RequestUserSysNo { get; set; }
        public DateTime? RequestTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public DateTime? VoucherTime { get; set; }
    }
}
