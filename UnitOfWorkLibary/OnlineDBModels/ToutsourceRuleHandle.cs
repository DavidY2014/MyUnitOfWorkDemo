using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ToutsourceRuleHandle
    {
        public int OutsourceRuleHandleId { get; set; }
        public int? OutsourceRuleId { get; set; }
        public int? OutsourceRuleUsageId { get; set; }
        public string HandleType { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
