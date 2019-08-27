using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ShipTypeHousePurchaseTt
    {
        public int SysNo { get; set; }
        public int ShipTypeSysNo { get; set; }
        public int ShipType { get; set; }
        public string ShipDescription { get; set; }
    }
}
