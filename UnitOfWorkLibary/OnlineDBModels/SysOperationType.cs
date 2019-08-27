using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysOperationType
    {
        public int SysNo { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public int? Status { get; set; }
    }
}
