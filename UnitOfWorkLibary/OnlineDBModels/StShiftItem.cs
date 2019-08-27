using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StShiftItem
    {
        public int ShiftSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int ShiftQty { get; set; }
        public int SysNo { get; set; }
        public decimal? Cost { get; set; }
        public int? ShiftOut { get; set; }
        public int? ShiftIn { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal VatRate { get; set; }
        public decimal NetCost { get; set; }

        public virtual StShift ShiftSysNoNavigation { get; set; }
    }
}
