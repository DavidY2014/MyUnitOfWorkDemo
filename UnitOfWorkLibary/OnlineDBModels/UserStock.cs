using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class UserStock
    {
        public int SysNo { get; set; }
        public int UserSysNo { get; set; }
        public int StockSysNo { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int Status { get; set; }
    }
}
