using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TnodeSchedule
    {
        public int NodeId { get; set; }
        public int ScheduleId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string Status { get; set; }
    }
}
