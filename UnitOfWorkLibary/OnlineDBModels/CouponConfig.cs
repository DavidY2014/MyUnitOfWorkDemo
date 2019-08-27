using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CouponConfig
    {
        public int SysNo { get; set; }
        public int BatchNo { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ImageName { get; set; }
        public int LimitNum { get; set; }
        public int VirtualNum { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDt { get; set; }
    }
}
