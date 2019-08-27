using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TautoTaskLog
    {
        public int LogId { get; set; }
        public string TaskId { get; set; }
        public string ServerId { get; set; }
        public string LogContent { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int SuccessCount { get; set; }
        public int FailedCount { get; set; }
        public int IgnoreCount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
