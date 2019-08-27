using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TdynamicSql
    {
        public string SqlUsageCode { get; set; }
        public string SqlUsageName { get; set; }
        public string Sqlstatement { get; set; }
        public string SqlUsageType { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
