using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TdataPublisher
    {
        public string DataPublisherId { get; set; }
        public string DataPublisherName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int IntervalMinute { get; set; }
        public DateTime LastExecuteTime { get; set; }
        public string DataSourceType { get; set; }
        public string SqlStatement { get; set; }
        public string ClassName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
