using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ShipTypePayTypeUnRef
    {
        public int SysNo { get; set; }
        public int ShipTypeSysNo { get; set; }
        public int PayTypeSysNo { get; set; }
    }
}
