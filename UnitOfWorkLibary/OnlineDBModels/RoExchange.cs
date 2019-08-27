using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RoExchange
    {
        public int SysNo { get; set; }
        public string ExchangeId { get; set; }
        public int Type { get; set; }
        public int CustomerSysNo { get; set; }
        public string CustomerDepartmentComparyName { get; set; }
        public int ReferSysNo { get; set; }
        public int StockSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public int? OutUserSysNo { get; set; }
        public DateTime? OutTime { get; set; }
    }
}
