using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TnodeInstance
    {
        public int NodeInstanceId { get; set; }
        public string NodeInstanceName { get; set; }
        public int ProcessInstanceId { get; set; }
        public int NodeId { get; set; }
        public int Executor { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? EarliestDateExpired { get; set; }
        public DateTime? StardandDateExpired { get; set; }
        public DateTime? LastDateExpired { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string Status { get; set; }
    }
}
