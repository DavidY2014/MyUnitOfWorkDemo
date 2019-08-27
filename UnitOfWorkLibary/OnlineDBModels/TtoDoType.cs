using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TtoDoType
    {
        public string ToDoTypeId { get; set; }
        public string ToDoTypeName { get; set; }
        public string IsAlertWhenDelay { get; set; }
        public int DelayTime { get; set; }
        public int ErrorLogKeepDays { get; set; }
        public string EventNoticeId { get; set; }
        public int NoticeInterval { get; set; }
        public DateTime? DateNoticed { get; set; }
        public int MaxRetryTime1 { get; set; }
        public int RetryIntervalMinute1 { get; set; }
        public int MaxRetryTime2 { get; set; }
        public int RetryIntervalMinute2 { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
