using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class GiftCardLog
    {
        public int SysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public int? OrderType { get; set; }
        public int OrderSysNo { get; set; }
        public int GiftCardSysNo { get; set; }
        public decimal GiftCardAmount { get; set; }
        public int LogUserSysNo { get; set; }
        public DateTime LogTime { get; set; }
        public int LogType { get; set; }
    }
}
