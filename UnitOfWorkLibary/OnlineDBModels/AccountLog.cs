using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AccountLog
    {
        public int SysNo { get; set; }
        public int? CustomerSysNo { get; set; }
        public int? CustomerType { get; set; }
        public string OrderSysNo { get; set; }
        public int? AccountType { get; set; }
        public decimal? OrderAccountQuota { get; set; }
        public DateTime? CreateTime { get; set; }
        public int LogType { get; set; }
    }
}
