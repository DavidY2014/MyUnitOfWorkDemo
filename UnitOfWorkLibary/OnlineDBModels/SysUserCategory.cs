using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysUserCategory
    {
        public int SysNo { get; set; }
        public int UserSysNo { get; set; }
        public int CategoryType { get; set; }
        public int CategorySysNo { get; set; }
        public int? CategoryRoleSysNo { get; set; }
    }
}
