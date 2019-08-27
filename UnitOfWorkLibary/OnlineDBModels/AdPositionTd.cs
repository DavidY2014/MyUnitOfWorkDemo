using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdPositionTd
    {
        public int SysNo { get; set; }
        public string Name { get; set; }
        public int? ChannelType { get; set; }
        public int? Status { get; set; }
    }
}
