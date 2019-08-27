using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysUser
    {
        public SysUser()
        {
            SysUserRole = new HashSet<SysUserRole>();
        }

        public int SysNo { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public int? BossSysNo { get; set; }
        public int? DepartmentSysNo { get; set; }
        public int? BranchSysNo { get; set; }
        public string MobilePhone { get; set; }
        public int Flag { get; set; }
        public int? StationSysNo { get; set; }
        public int? PmgroupSysNo { get; set; }
        public int? Tsrgroup { get; set; }
        public string Isfreeze { get; set; }
        public string HmcustomerType { get; set; }
        public int ParentSysNo { get; set; }
        public DateTime? LastChangePwdTime { get; set; }

        public virtual ICollection<SysUserRole> SysUserRole { get; set; }
    }
}
