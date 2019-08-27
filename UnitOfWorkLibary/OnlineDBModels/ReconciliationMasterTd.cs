using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ReconciliationMasterTd
    {
        public int SysNo { get; set; }
        public string CustomerGroupName { get; set; }
        public string DepartmentName { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int IsReconciliation { get; set; }
        public int IsSendMail { get; set; }
        public int ValidCount { get; set; }
        public string WordName { get; set; }
        public string ErrorMessage { get; set; }
        public int ReconciliationMonth { get; set; }
        public string CustomerId { get; set; }
        public int CustomerDepartmentSysNo { get; set; }
        public string DepartmentCompanyName { get; set; }
        public int? AccountId { get; set; }
        public string CustomerCompanyName { get; set; }
        public int BranchSysNo { get; set; }
    }
}
