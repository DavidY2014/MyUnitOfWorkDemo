using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class VaApMap
    {
        public int SysNo { get; set; }
        public int ApsysNo { get; set; }
        public int VasysNo { get; set; }
        public decimal VendorAdvanceAmt { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
