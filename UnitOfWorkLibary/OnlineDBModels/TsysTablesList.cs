using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TsysTablesList
    {
        public string TableName { get; set; }
        public string TableDescription { get; set; }
        public string IsAllowCache { get; set; }
        public string IsEnableCache { get; set; }
        public int CacheMinute { get; set; }
    }
}
