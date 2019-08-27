using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysPrivilege
    {
        public SysPrivilege()
        {
            SysRolePrivilege = new HashSet<SysRolePrivilege>();
        }

        public int SysNo { get; set; }
        public string PrivilegeId { get; set; }
        public string PrivilegeName { get; set; }
        public int Status { get; set; }

        public virtual ICollection<SysRolePrivilege> SysRolePrivilege { get; set; }
    }
}
