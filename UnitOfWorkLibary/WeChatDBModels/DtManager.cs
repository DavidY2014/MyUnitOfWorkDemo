using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtManager
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int? RoleType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string RealName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int? IsLock { get; set; }
        public DateTime? AddTime { get; set; }
        public int? WxNum { get; set; }
        public int? AgentId { get; set; }
        public string RegIp { get; set; }
        public string Qq { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Remark { get; set; }
        public int? SortId { get; set; }
        public int? AgentLevel { get; set; }
    }
}
