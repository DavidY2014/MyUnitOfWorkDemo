using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StAdjust
    {
        public StAdjust()
        {
            StAdjustItem = new HashSet<StAdjustItem>();
        }

        public int SysNo { get; set; }
        public string AdjustId { get; set; }
        public int StockSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? OutTime { get; set; }
        public int? OutUserSysNo { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalNetCost { get; set; }

        public virtual ICollection<StAdjustItem> StAdjustItem { get; set; }
    }
}
