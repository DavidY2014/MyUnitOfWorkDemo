using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerPointLog
    {
        public int SysNo { get; set; }
        public int? CustomerSysNo { get; set; }
        public int? PointLogType { get; set; }
        public int? PointAmount { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Memo { get; set; }
        public string LogCheck { get; set; }
        public DateTime? PointLimitedDate { get; set; }
        public string ReceiptSysNo { get; set; }
        public int? Status { get; set; }
    }
}
