using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class BranchConfig
    {
        public int SysNo { get; set; }
        public string BranchName { get; set; }
        public int CommPoint { get; set; }
        public int IsCreateReferBills { get; set; }
        public string ReconciliationTemplateName { get; set; }
        public int CustomerSysNo { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserSysNo { get; set; }
        public DateTime UpdateTime { get; set; }
        public int Status { get; set; }
    }
}
