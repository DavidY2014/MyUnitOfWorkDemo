using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class Tschedule
    {
        public int ScheduleId { get; set; }
        public string ScheduleName { get; set; }
        public string UsageType { get; set; }
        public string UsageKeyValue { get; set; }
        public string IntervalType { get; set; }
        public short IntervalValue { get; set; }
        public string InnerWeekValue { get; set; }
        public string InnerMonthValue { get; set; }
        public string DailyFrequency { get; set; }
        public string DailyOnceTime { get; set; }
        public string DailyIntervalType { get; set; }
        public int DailyInterval { get; set; }
        public string DailyStartTime { get; set; }
        public string DailyEndTime { get; set; }
        public DateTime? LastRunTime { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
