using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ReconciliationItem
    {
        public int SysNo { get; set; }
        public int MasterSysNo { get; set; }
        public int RefeSysNo { get; set; }
        public int ReconciliationType { get; set; }
    }
}
