using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RoRefund
    {
        public int SysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public string RefundId { get; set; }
        public int RosysNo { get; set; }
        public int SosysNo { get; set; }
        public int PayTypeId { get; set; }
        public string TradeNo { get; set; }
        public int? RefundPayType { get; set; }
        public decimal? RefundMoney { get; set; }
        public int? RefundStatus { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public string RefundReason { get; set; }
        public string RefundLog { get; set; }
    }
}
