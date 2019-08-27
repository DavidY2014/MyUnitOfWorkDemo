using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RoExchangeItem
    {
        public int SysNo { get; set; }
        public int MasterSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public decimal Cost { get; set; }
        public int Qty { get; set; }
    }
}
