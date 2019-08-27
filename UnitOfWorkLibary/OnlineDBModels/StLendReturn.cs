using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StLendReturn
    {
        public int LendSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int ReturnQty { get; set; }
        public DateTime ReturnTime { get; set; }
        public int? AsnsysNo { get; set; }
        public int SysNo { get; set; }
        public int ReturnUserSysNo { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual StLend LendSysNoNavigation { get; set; }
    }
}
