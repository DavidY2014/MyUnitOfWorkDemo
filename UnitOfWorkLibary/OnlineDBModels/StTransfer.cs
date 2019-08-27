using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StTransfer
    {
        public StTransfer()
        {
            StTransferItem = new HashSet<StTransferItem>();
        }

        public int SysNo { get; set; }
        public string TransferId { get; set; }
        public int StockSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? OutTime { get; set; }
        public int? OutUserSysNo { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public int? SyncStatus { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public decimal SourceCost { get; set; }
        public decimal SourceNetCost { get; set; }
        public decimal TargetCost { get; set; }
        public decimal TargetNetCost { get; set; }

        public virtual ICollection<StTransferItem> StTransferItem { get; set; }
    }
}
