using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StShift
    {
        public StShift()
        {
            StShiftItem = new HashSet<StShiftItem>();
        }

        public int SysNo { get; set; }
        public string ShiftId { get; set; }
        public int StockSysNoA { get; set; }
        public int StockSysNoB { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? OutTime { get; set; }
        public int? OutUserSysNo { get; set; }
        public DateTime? InTime { get; set; }
        public int? InUserSysNo { get; set; }
        public int? CheckQtyUserSysNo { get; set; }
        public DateTime? CheckQtyTime { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public int? DlsysNo { get; set; }
        public int? FreightUserSysNo { get; set; }
        public DateTime? SetDeliveryManTime { get; set; }
        public int? IsLarge { get; set; }
        public string Wmsid { get; set; }
        public int? SyncStatus { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int BranchId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalNetCost { get; set; }
        public int ShipTypeSysNo { get; set; }

        public virtual ICollection<StShiftItem> StShiftItem { get; set; }
    }
}
