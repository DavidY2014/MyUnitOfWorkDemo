using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerPointRequest
    {
        public int SysNo { get; set; }
        public int? CustomerSysNo { get; set; }
        public int? PointSourceType { get; set; }
        public int? PointSourceSysNo { get; set; }
        public int? SosysNo { get; set; }
        public int? PointLogType { get; set; }
        public int? PointAmount { get; set; }
        public int? RequestUserType { get; set; }
        public int? RequestUserSysNo { get; set; }
        public DateTime? RequestTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AddUserSysNo { get; set; }
        public DateTime? AddTime { get; set; }
        public int? AbandonUserSysNo { get; set; }
        public DateTime? AbandonTime { get; set; }
        public string Memo { get; set; }
        public int? Status { get; set; }
        public int? PmuserSysNo { get; set; }
    }
}
