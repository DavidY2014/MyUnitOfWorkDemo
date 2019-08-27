using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class Tnode
    {
        public int NodeId { get; set; }
        public int ProcessVersionId { get; set; }
        public string NodeType { get; set; }
        public string NodeName { get; set; }
        public string NodeInstanceName { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public string IsAutoExecute { get; set; }
        public string IsAutoAllocateActor { get; set; }
        public string IsMultiActor { get; set; }
        public int EarliestTimeLimitId { get; set; }
        public int StandardTimeLimitId { get; set; }
        public int LastTimeLimitId { get; set; }
        public string IsCancelWhenExpired { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
