using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RecommendProduct
    {
        public int SysNo { get; set; }
        public int? PositionSysNo { get; set; }
        public int? ChannelType { get; set; }
        public int? AdTypeSysNo { get; set; }
        public int? OrderNo { get; set; }
        public int? ProductSysNo { get; set; }
        public int? C1sysNo { get; set; }
        public int? C2sysNo { get; set; }
        public int? C3sysNo { get; set; }
        public int? Status { get; set; }
        public string Brand { get; set; }
        public decimal? MaxRank { get; set; }
        public decimal? MinRank { get; set; }
    }
}
