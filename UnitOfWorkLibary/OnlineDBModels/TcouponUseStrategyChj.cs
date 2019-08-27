using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TcouponUseStrategyChj
    {
        public int StrategyId { get; set; }
        public int BatchId { get; set; }
        public string StrategyType { get; set; }
        public int ReferId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
