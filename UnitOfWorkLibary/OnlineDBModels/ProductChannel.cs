using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductChannel
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int ChanelType { get; set; }
        public int ShowType { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }

        public virtual Product ProductSysNoNavigation { get; set; }
    }
}
