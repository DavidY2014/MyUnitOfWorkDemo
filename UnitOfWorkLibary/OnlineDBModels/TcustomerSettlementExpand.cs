using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TcustomerSettlementExpand
    {
        public int CustomerSettlementId { get; set; }
        public int CustomerId { get; set; }
        public decimal AvalibaleQuota { get; set; }
        public decimal TotalQuota { get; set; }
        public string SettlementType { get; set; }
        public int SettlementPeriod { get; set; }
        public int SettleDay { get; set; }
        public int BufferSettlementPeriod { get; set; }
        public decimal BufferQuota { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
