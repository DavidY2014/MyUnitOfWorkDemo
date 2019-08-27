using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TcouponGift
    {
        public int GiftId { get; set; }
        public int BatchId { get; set; }
        public int ItemSkuId { get; set; }
        public int Qty { get; set; }
        public decimal GiftAmount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
