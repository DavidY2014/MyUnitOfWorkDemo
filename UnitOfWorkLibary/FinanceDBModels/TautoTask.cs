using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TautoTask
    {
        public string TaskId { get; set; }
        public string ServerId { get; set; }
        public string ClassId { get; set; }
        public string TaskName { get; set; }
        public string IsAutoExecute { get; set; }
        public string IsEnableAlert { get; set; }
        public string ClassName { get; set; }
        public int LogKeepDays { get; set; }
        public string InitialValue { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
