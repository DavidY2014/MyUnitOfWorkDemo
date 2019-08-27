using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TautoReportExportFile
    {
        public int FileId { get; set; }
        public int ReportId { get; set; }
        public string FileFormat { get; set; }
        public string FileName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
