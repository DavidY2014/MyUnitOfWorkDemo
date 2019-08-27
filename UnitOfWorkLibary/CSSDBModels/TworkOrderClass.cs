using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TworkOrderClass
    {
        public int ClassId { get; set; }
        public string WorkOrderTypeId { get; set; }
        public string ClassName { get; set; }
        public byte ClassLevel { get; set; }
        public int ParentClassId { get; set; }
        public string IsLastLevel { get; set; }
        public string IsShowScript { get; set; }
        public string ScriptText { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public int ShowOrder { get; set; }
        public int RuleId { get; set; }
    }
}
