using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ToutsourceRuleBrand
    {
        public int OutsourceRuleBrandId { get; set; }
        public int OutsourceRuleId { get; set; }
        public int BrandId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
