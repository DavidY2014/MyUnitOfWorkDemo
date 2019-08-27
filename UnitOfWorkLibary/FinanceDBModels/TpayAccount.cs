using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TpayAccount
    {
        public int PayAccountId { get; set; }
        public string PayAccountCode { get; set; }
        public string PayAccountName { get; set; }
        public string PayBankAccount { get; set; }
        public string OpenBank { get; set; }
        public string BankAddress { get; set; }
        public string PayPassword { get; set; }
        public string PayCallBackUrl { get; set; }
        public string IsHostToHost { get; set; }
        public string PayServiceUrl { get; set; }
        public string PayAccountRemark { get; set; }
        public string Status { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string PaySignPort { get; set; }
        public string PayHttpsPort { get; set; }
    }
}
