using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class DoConfirmCfg
    {
        public int SysNo { get; set; }
        public int? CustomerSysNo { get; set; }
        public int? IsAutoConfirm { get; set; }
        public int? DelayDays { get; set; }
        public int? MaxDelayNum { get; set; }
        public int? Status { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
