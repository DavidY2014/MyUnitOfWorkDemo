using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ApiOrderMasterVendor
    {
        public int SysNo { get; set; }
        public int ApisomasterSysNo { get; set; }
        public int VenderSysNo { get; set; }
        public int PpmuserSysNo { get; set; }
        public decimal CommPoint { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int ProductSysNo { get; set; }
    }
}
