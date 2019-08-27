using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RmaShiftTd
    {
        public int SysNo { get; set; }
        public int? RegisterSysNo { get; set; }
        public int? RmashiftType { get; set; }
        public int? ShiftSysNo { get; set; }
    }
}
