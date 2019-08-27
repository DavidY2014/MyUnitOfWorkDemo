using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DoConfirm
    {
        public int SysNo { get; set; }
        public int? DoSysNo { get; set; }
        public int? DelayCount { get; set; }
        public int? Status { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
