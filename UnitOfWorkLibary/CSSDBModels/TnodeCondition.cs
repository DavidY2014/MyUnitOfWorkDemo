using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TnodeCondition
    {
        public int NodeId { get; set; }
        public string DynamicCompileFile { get; set; }
        public string StartCondition { get; set; }
        public string StartConditionDisplayNote { get; set; }
        public string CompleteCondition { get; set; }
        public string EndConditionDisplayNote { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
