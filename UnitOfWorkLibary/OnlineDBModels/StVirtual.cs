using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StVirtual
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int VirtualQty { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
    }
}
