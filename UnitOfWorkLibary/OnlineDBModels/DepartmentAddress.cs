using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DepartmentAddress
    {
        public int SysNo { get; set; }
        public int DepartmentSysNo { get; set; }
        public int AddressSysNo { get; set; }
        public int IsValid { get; set; }
        public int CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? IsDefault { get; set; }
    }
}
