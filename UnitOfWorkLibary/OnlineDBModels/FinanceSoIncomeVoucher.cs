using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class FinanceSoIncomeVoucher
    {
        public int SysNo { get; set; }
        public int? FsisysNo { get; set; }
        public string VoucherId { get; set; }
        public int? SysUserSysNo { get; set; }
        public DateTime? DateStamp { get; set; }
        public DateTime? VoucherTime { get; set; }
    }
}
