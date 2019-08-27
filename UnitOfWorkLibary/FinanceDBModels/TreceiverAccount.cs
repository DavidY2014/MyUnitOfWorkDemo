using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TreceiverAccount
    {
        public int ReceiverAccountId { get; set; }
        public string ReceiverAccountCode { get; set; }
        public string ReceiverAccountName { get; set; }
        public string ReceiverBankAccount { get; set; }
        public string OpenBank { get; set; }
        public string BankAddress { get; set; }
        public string ReceiverRemark { get; set; }
        public string Status { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string BankProvince { get; set; }
        public string BankCity { get; set; }
        public int PayTimes { get; set; }
    }
}
