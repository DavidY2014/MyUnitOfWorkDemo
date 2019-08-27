using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RoSaleRuleItem
    {
        public int SysNo { get; set; }
        public int RosysNo { get; set; }
        public int SosysNo { get; set; }
        public int SrsysNo { get; set; }
        public int RefundTimes { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
