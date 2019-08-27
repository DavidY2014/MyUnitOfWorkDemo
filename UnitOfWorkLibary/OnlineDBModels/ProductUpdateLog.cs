using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductUpdateLog
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public string LogType { get; set; }
        public int? UpdateCount { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}
