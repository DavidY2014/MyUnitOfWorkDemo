using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TfundTransfer
    {
        public int FundTransferId { get; set; }
        public int? FundId { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public int BranchId { get; set; }
        public DateTime InputFundTime { get; set; }
        public string VerificationStatus { get; set; }
        public decimal Amount { get; set; }
        public decimal UnVerificationAmount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
