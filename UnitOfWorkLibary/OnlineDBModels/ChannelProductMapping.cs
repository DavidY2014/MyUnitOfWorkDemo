using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ChannelProductMapping
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Type { get; set; }
        public string ChannelProductId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public string OppositeUnitOfMeasure { get; set; }
        public int Status { get; set; }
        public int IsSyncApi { get; set; }
    }
}
