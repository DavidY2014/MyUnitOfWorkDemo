using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class VendorReplenishmentDays
    {
        public int SysNo { get; set; }
        public int VendorSysNo { get; set; }
        public int ReplenishCrycleType { get; set; }
        public string ReplenishDayIndex { get; set; }
        public int? ScopeType { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
