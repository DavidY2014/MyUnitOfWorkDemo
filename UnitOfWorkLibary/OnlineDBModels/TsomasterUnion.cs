using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TsomasterUnion
    {
        public int SysNo { get; set; }
        public int UnionOrderId { get; set; }
        public int OrderId { get; set; }
        public DateTime UnionTime { get; set; }
        public int AuditCount { get; set; }
        public int UnionAuditCount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
