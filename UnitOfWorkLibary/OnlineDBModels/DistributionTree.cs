using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DistributionTree
    {
        public int SysNo { get; set; }
        public string AreaName { get; set; }
        public string Member { get; set; }
        public string ChildMember { get; set; }
        public string CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Defalut1 { get; set; }
        public int? Defalut2 { get; set; }
        public DateTime? Defalut3 { get; set; }
    }
}
