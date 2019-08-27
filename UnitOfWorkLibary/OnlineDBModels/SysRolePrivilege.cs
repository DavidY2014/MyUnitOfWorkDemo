using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysRolePrivilege
    {
        public int SysNo { get; set; }
        public int RoleSysNo { get; set; }
        public int PrivilegeSysNo { get; set; }

        public virtual SysPrivilege PrivilegeSysNoNavigation { get; set; }
        public virtual SysRole RoleSysNoNavigation { get; set; }
    }
}
