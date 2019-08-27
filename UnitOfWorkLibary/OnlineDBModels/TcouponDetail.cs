using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TcouponDetail
    {
        public int CouponCodeId { get; set; }
        public int BatchId { get; set; }
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public DateTime UseTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string CouponStatus { get; set; }
        public string Status { get; set; }
        public string IsSendMessage { get; set; }
    }
}
