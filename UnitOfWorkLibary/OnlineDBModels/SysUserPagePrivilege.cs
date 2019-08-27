using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysUserPagePrivilege
    {
        public int SysNo { get; set; }
        public int SysUserSysNo { get; set; }
        public int SysMenuSysNo { get; set; }
        public string SysMenuHref { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
