using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TnodeInstanceHandle
    {
        public int HandelId { get; set; }
        public int NodeInstanceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Executor { get; set; }
    }
}
