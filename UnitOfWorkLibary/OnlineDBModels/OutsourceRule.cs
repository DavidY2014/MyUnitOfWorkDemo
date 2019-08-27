using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class OutsourceRule
    {
        public int SysNo { get; set; }
        public int CitySysNo { get; set; }
        public int C2sysNo { get; set; }
        public int VendorSysNo { get; set; }
        public decimal CommPoint { get; set; }
        public int PpmuserSysNo { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
