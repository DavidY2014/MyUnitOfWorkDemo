using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SpecialProduct
    {
        public long SysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Status { get; set; }
        public string Editor { get; set; }
        public DateTime? EditTime { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public int SyncStatus { get; set; }
        public int IsVisible { get; set; }
    }
}
