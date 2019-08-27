using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class WmsDeliverNo
    {
        public int SysNo { get; set; }
        public string Docno { get; set; }
        public string Deliveryno { get; set; }
        public DateTime Addtime { get; set; }
        public string OrderType { get; set; }
    }
}
