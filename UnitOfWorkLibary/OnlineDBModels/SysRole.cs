using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysRole
    {
        public SysRole()
        {
            SysRolePrivilege = new HashSet<SysRolePrivilege>();
            SysUserRole = new HashSet<SysUserRole>();
        }

        public int SysNo { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public int Status { get; set; }
        public int? OperationTypeId { get; set; }

        public virtual ICollection<SysRolePrivilege> SysRolePrivilege { get; set; }
        public virtual ICollection<SysUserRole> SysUserRole { get; set; }
    }
}
