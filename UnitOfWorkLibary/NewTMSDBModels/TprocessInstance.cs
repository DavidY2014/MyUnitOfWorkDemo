using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TprocessInstance
    {
        public int ProcessInstanceId { get; set; }
        public int ProcessVersionId { get; set; }
        public string ProcessInstanceName { get; set; }
        public string KeyValue { get; set; }
        public string RelavantData { get; set; }
        public DateTime? EarliestDateExpired { get; set; }
        public DateTime? StardandDateExpired { get; set; }
        public DateTime? LastDateExpired { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
