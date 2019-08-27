using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TparcelInterception
    {
        public int InterceptionId { get; set; }
        public int ParcelId { get; set; }
        public string SalesOrderNo { get; set; }
        public string StockOrderNo { get; set; }
        public string InterceptionReason { get; set; }
        public string Status { get; set; }
        public string FailedReason { get; set; }
        public string InterceptedUser { get; set; }
        public DateTime? DateIntercepted { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
