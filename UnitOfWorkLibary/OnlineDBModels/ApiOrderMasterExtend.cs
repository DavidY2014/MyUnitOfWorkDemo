using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ApiOrderMasterExtend
    {
        public int SysNo { get; set; }
        public int ApisomasterSysNo { get; set; }
        public string ColumnName { get; set; }
        public string ColumnRemark { get; set; }
        public string ColumnValue { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
