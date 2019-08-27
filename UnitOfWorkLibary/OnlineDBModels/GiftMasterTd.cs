using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class GiftMasterTd
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public string ListOrder { get; set; }
        public int Status { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int ProductSaleType { get; set; }
        public int? ChannelType { get; set; }
    }
}
