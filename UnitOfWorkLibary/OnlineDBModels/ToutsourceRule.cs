using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ToutsourceRule
    {
        public int OutsourceRuleId { get; set; }
        public int OutsourceRuleUsageId { get; set; }
        public string DeliveryType { get; set; }
        public string OutsourceType { get; set; }
        public string LimitType { get; set; }
        public int VendorId { get; set; }
        public int PurchaseUserId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
