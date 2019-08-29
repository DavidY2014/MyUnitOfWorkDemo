using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtUserAmountLog
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Type { get; set; }
        public string OrderNo { get; set; }
        public string TradeNo { get; set; }
        public int? PaymentId { get; set; }
        public decimal? Value { get; set; }
        public string Remark { get; set; }
        public byte? Status { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? CompleteTime { get; set; }
    }
}
