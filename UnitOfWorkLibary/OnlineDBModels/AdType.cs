using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdType
    {
        public int SysNo { get; set; }
        public string Name { get; set; }
        public int? AdPositionSysNo { get; set; }
        public int? OrderNo { get; set; }
        public int? ChannelType { get; set; }
        public int? Status { get; set; }
    }
}
