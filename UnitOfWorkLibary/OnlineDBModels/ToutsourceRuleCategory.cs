using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ToutsourceRuleCategory
    {
        public int OutsourceRuleCategoryId { get; set; }
        public int OutsourceRuleId { get; set; }
        public int CategoryId1 { get; set; }
        public int CategoryId2 { get; set; }
        public int CategoryId3 { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
