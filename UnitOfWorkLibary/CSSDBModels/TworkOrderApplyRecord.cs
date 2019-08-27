using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderApplyRecord
    {
        public int WorkOrderApplyRecordId { get; set; }
        public int WorkOrderId { get; set; }
        public int ApplyUserId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
