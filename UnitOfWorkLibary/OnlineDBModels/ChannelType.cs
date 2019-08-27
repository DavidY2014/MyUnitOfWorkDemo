using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ChannelType
    {
        public int SysNo { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int IsUseSearch { get; set; }
        public int IsSyncApi { get; set; }
        public int IsSyncWms { get; set; }
    }
}
