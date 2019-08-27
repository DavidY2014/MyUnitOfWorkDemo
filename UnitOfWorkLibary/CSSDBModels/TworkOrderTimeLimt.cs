using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderTimeLimt
    {
        public int WorkOrderId { get; set; }
        public int NodeId { get; set; }
        public DateTime? NormalTime { get; set; }
        public DateTime? RealTime { get; set; }
    }
}
