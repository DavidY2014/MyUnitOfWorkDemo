using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ContractOperatedLogTd
    {
        public int SysNo { get; set; }
        public int OperateUserSysNo { get; set; }
        public DateTime OperateTime { get; set; }
        public int Operation { get; set; }
        public int ContractMasterSysNo { get; set; }
    }
}
