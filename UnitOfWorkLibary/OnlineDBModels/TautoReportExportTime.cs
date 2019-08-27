using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TautoReportExportTime
    {
        public int ReportId { get; set; }
        public string ExecuteTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastExecuteTime { get; set; }
    }
}
