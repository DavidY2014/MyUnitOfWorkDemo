using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AsnTemp
    {
        public int SysNo { get; set; }
        public int AsnsysNo { get; set; }
        public int ReferSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int StockSysNo { get; set; }
        public int ReceiveQty { get; set; }
        public DateTime InTime { get; set; }
        public int ReturnType { get; set; }
        public decimal? OrderPrice { get; set; }
    }
}
