using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TnodeLink
    {
        public int LinkId { get; set; }
        public int PriorNodeId { get; set; }
        public int NextNodeId { get; set; }
        public string DynamicCompileFile { get; set; }
        public string IsJumpByCondition { get; set; }
        public string JumpCondition { get; set; }
        public string JumpConditionDisplayNote { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
