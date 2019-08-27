using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TtimeLimitRule
    {
        public int RuleId { get; set; }
        public string WorkOrderTypeId { get; set; }
        public string RuleName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
    }
}
