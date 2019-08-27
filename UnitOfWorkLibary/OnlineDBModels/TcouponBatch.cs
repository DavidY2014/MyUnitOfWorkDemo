using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TcouponBatch
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public int SiteId { get; set; }
        public decimal CouponAmt { get; set; }
        public decimal SaleAmt { get; set; }
        public decimal DisCount { get; set; }
        public string CouponType { get; set; }
        public string BatchType { get; set; }
        public string CouponCode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string DetailLink { get; set; }
        public int CustomerUseNum { get; set; }
        public int Qty { get; set; }
        public string IsShowOnWeb { get; set; }
        public int AlreadySend { get; set; }
        public int AlreadyUse { get; set; }
        public int DeleteCount { get; set; }
        public int AuditUserId { get; set; }
        public DateTime AuditTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string BatchStatus { get; set; }
        public string Status { get; set; }
    }
}
