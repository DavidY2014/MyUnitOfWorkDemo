using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StLend
    {
        public StLend()
        {
            StLendItem = new HashSet<StLendItem>();
            StLendReturn = new HashSet<StLendReturn>();
        }

        public int SysNo { get; set; }
        public string LendId { get; set; }
        public int StockSysNo { get; set; }
        public int LendUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? OutTime { get; set; }
        public int? OutUserSysNo { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public int Type { get; set; }
        public int DepartmentSysNo { get; set; }
        public int? SyncStatus { get; set; }
        public string Receiver { get; set; }
        public string ReceiverTelPhone { get; set; }
        public string ReceiverMobilePhone { get; set; }
        public string ReceiverAddress { get; set; }
        public int? ReceiverAreaSysNo { get; set; }
        public string Route { get; set; }
        public int? IsSyncG7 { get; set; }
        public int ShipTypeSysNo { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalNetCost { get; set; }

        public virtual ICollection<StLendItem> StLendItem { get; set; }
        public virtual ICollection<StLendReturn> StLendReturn { get; set; }
    }
}
