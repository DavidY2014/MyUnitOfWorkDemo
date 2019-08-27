using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StAdjustItem
    {
        public int SysNo { get; set; }
        public int AdjustSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int AdjustQty { get; set; }
        public decimal? AdjustCost { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal VatRate { get; set; }
        public decimal NetCost { get; set; }

        public virtual StAdjust AdjustSysNoNavigation { get; set; }
    }
}
