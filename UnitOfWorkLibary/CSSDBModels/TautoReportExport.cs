using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TautoReportExport
    {
        public int ReportId { get; set; }
        public string ReportCode { get; set; }
        public string ReportName { get; set; }
        public string SqlStatement { get; set; }
        public string FileFormat { get; set; }
        public string FilePath { get; set; }
        public string ExecuteDay { get; set; }
        public string IsSendMail { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
