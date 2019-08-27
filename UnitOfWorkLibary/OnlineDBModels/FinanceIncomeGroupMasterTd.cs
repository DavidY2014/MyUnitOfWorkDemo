using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinanceIncomeGroupMasterTd
    {
        public int SysNo { get; set; }
        public string DepartmentName { get; set; }
        public string CustomerGroup { get; set; }
        public int Status { get; set; }
        public decimal PaidinPay { get; set; }
        public decimal AmountPay { get; set; }
        public string Diversity { get; set; }
        public string Remark { get; set; }
        public int Type { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? VerificationTime { get; set; }
        public int BranchSysNo { get; set; }
    }
}
