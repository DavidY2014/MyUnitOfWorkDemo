using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ToutsourceRuleUsage
    {
        public int OutsourceRuleUsageId { get; set; }
        public int UsageId { get; set; }
        public string UsageType { get; set; }
        public string PriorityLevel { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
