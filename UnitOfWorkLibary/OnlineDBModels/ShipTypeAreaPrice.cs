using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ShipTypeAreaPrice
    {
        public int SysNo { get; set; }
        public int ShipTypeSysNo { get; set; }
        public int AreaSysNo { get; set; }
        public int BaseWeight { get; set; }
        public int TopWeight { get; set; }
        public int UnitWeight { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal MaxPrice { get; set; }
    }
}
