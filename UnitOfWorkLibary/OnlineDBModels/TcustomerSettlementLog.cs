using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TcustomerSettlementLog
    {
        public int CustomerSettlementLogId { get; set; }
        public string LogType { get; set; }
        public int CustomerId { get; set; }
        public int ChannelId { get; set; }
        public string SettlementType { get; set; }
        public int ReferId { get; set; }
        public string ReferType { get; set; }
        public decimal SettlementQuota { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
