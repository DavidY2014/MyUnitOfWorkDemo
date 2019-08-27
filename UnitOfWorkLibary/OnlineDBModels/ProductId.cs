using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductId
    {
        public int? ProductSysNo { get; set; }
        public int? PosysNo { get; set; }
        public int? OrderNum { get; set; }
        public int? Status { get; set; }
        public string ProductSn { get; set; }
        public string ProductTrackSn { get; set; }
        public string Note { get; set; }
        public int? ShelveUserSysNo { get; set; }
        public DateTime? ShelveTime { get; set; }
        public string StockNo { get; set; }
        public int SysNo { get; set; }
        public int? Asnsysno { get; set; }
    }
}
