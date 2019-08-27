using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CmschannelConfig
    {
        public int SysNo { get; set; }
        public int? Cmstype { get; set; }
        public int? ChannelType { get; set; }
        public int? ReferSysNo { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
