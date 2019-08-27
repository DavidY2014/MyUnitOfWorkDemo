using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SaleUnitMap
    {
        public int SysNo { get; set; }
        public string InterfaceCode { get; set; }
        public int? IsValid { get; set; }
        public string SysUnit { get; set; }
        public string InterfaceUnit { get; set; }
        public int? C3sysNo { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? EditTime { get; set; }
    }
}
