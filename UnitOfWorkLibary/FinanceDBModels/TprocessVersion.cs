using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TprocessVersion
    {
        public int ProcessVersionId { get; set; }
        public string ProcessName { get; set; }
        public string ProcessInstanceName { get; set; }
        public string ProcessDescription { get; set; }
        public string VersionId { get; set; }
        public string ClassName { get; set; }
        public int ConstructParameterSetId { get; set; }
        public int ProcessId { get; set; }
        public string IsAutoExecute { get; set; }
        public int EarliestTimeLimitId { get; set; }
        public int StandardTimeLimitId { get; set; }
        public int LastTimeLimitId { get; set; }
        public string IsCancelWhenExpired { get; set; }
        public string XmlData { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
