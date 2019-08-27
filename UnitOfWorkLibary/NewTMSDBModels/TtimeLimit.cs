using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TtimeLimit
    {
        public int TimeLimitId { get; set; }
        public string TimeLimtName { get; set; }
        public string IntervalType { get; set; }
        public short IntervalValue { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
