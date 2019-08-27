using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DepartmentVat
    {
        public int SysNo { get; set; }
        public int DepartmentSysNo { get; set; }
        public int VatsysNo { get; set; }
        public int IsValid { get; set; }
        public int? CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? IsDefault { get; set; }
    }
}
