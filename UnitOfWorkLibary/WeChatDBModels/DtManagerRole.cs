using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtManagerRole
    {
        public DtManagerRole()
        {
            DtManagerRoleValue = new HashSet<DtManagerRoleValue>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public byte? RoleType { get; set; }
        public byte? IsSys { get; set; }
        public int? AgentId { get; set; }

        public virtual ICollection<DtManagerRoleValue> DtManagerRoleValue { get; set; }
    }
}
