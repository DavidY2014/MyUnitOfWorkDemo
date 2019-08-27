using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class OrderTrade
    {
        public int SysNo { get; set; }
        public string TradeId { get; set; }
        public string TradeNo { get; set; }
        public DateTime UpdateTime { get; set; }
        public short IsAbandon { get; set; }
    }
}
