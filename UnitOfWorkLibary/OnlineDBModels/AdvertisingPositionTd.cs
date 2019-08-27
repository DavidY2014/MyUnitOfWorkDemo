using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdvertisingPositionTd
    {
        public int SysNo { get; set; }
        public int ChannelType { get; set; }
        public int PageChannelSysNo { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int AdType { get; set; }
        public string ContentFormat { get; set; }
        public int Qty { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public int C1sysNo { get; set; }
        public int C2sysNo { get; set; }
        public int C3sysNo { get; set; }
        public int CategoryPositionCode { get; set; }
    }
}
