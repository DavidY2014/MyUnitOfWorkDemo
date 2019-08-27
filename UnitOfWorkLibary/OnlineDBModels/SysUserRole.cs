using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysUserRole
    {
        public int SysNo { get; set; }
        public int UserSysNo { get; set; }
        public int RoleSysNo { get; set; }

        public virtual SysRole RoleSysNoNavigation { get; set; }
        public virtual SysUser UserSysNoNavigation { get; set; }
    }
}
