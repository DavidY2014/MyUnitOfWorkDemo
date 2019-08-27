using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysOperationTypePrivilege
    {
        public int SysNo { get; set; }
        public int? OperationTypeId { get; set; }
        public int? PrivilegeId { get; set; }
    }
}
