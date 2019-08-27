using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdvancedOrderVerification
    {
        public int SysNo { get; set; }
        public int OrderSysNo { get; set; }
        public int FinanceIncomeGroupMasterNo { get; set; }
        public decimal? VerificationAmount { get; set; }
        public short? OrderType { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? VerificationTime { get; set; }
        public int? VerificationUserSysNo { get; set; }
    }
}
