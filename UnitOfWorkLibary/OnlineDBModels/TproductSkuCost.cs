using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TproductSkuCost
    {
        public int ProductSkuCostId { get; set; }
        public int ProductSkuId { get; set; }
        public decimal UnitCost { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UpdateUserId { get; set; }
        public int BranchId { get; set; }
        public decimal NetCost { get; set; }
    }
}
