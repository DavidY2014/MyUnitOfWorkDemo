using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdvancedReceivedVerification
    {
        public int SysNo { get; set; }
        public int AdvancedFundSysNo { get; set; }
        public int FinanceIncomeGroupMasterNo { get; set; }
        public decimal? VerificationAmount { get; set; }
    }
}
