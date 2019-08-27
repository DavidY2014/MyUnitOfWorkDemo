using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SaleUnitOriTd
    {
        public int SysNo { get; set; }
        public string SaleUnit { get; set; }
        public int Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
