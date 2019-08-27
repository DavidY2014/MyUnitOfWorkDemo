using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StockOrderConfig
    {
        public int SysNo { get; set; }
        public int StockSysNo { get; set; }
        public int Type { get; set; }
        public string Value { get; set; }
        public int? Creator { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
