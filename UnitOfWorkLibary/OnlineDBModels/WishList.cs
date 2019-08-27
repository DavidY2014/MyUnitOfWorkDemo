using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class WishList
    {
        public int SysNo { get; set; }
        public int CustomerSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Remark { get; set; }
        public int? OperatorSysNo { get; set; }
    }
}
