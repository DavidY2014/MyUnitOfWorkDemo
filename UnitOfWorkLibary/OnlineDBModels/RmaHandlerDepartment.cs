using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RmaHandlerDepartment
    {
        public int DepartmentSysNo { get; set; }
        public string DepartmentName { get; set; }
        public int IsShowDuty { get; set; }
        public int IsShowExpense { get; set; }
        public DateTime CreateTime { get; set; }
        public int Order { get; set; }
    }
}
