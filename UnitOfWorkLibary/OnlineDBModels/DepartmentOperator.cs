using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DepartmentOperator
    {
        public int SysNo { get; set; }
        public int DepartmentSysNo { get; set; }
        public int Operator { get; set; }
        public int? DefaultAddressSysNo { get; set; }
        public int? DefaultVat { get; set; }
        public int? CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int OwnPurchase { get; set; }
        public int OwnAudit { get; set; }
        public int? DefaultDepartment { get; set; }
    }
}
