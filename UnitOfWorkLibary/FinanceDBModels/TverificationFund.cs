using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TverificationFund
    {
        public int VerificationFundId { get; set; }
        public int VerificationGroupId { get; set; }
        public int FundTransferId { get; set; }
        public int FundId { get; set; }
        public string FundSort { get; set; }
        public decimal VerificationAmount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
