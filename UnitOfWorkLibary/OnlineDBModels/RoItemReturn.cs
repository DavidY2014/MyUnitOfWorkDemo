using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RoItemReturn
    {
        public int SysNo { get; set; }
        public int RosysNo { get; set; }
        public int RoitemSysNo { get; set; }
        public int ReturnProductSysNo { get; set; }
        public int ReturnQty { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
