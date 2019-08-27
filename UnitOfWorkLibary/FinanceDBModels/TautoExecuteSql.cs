using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TautoExecuteSql
    {
        public string SqlId { get; set; }
        public string SqlName { get; set; }
        public string Remark { get; set; }
        public string HasReturnData { get; set; }
        public string ExecuteDay { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int IntervalMinute { get; set; }
        public DateTime? LastExecuteTime { get; set; }
        public string SqlStatement { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
