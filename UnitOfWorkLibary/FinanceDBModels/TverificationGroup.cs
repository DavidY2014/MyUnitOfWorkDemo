using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TverificationGroup
    {
        public int VerificationGroupId { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public decimal ReceivablesAmount { get; set; }
        public decimal ActualReceivablesAmount { get; set; }
        public string DifferenceReason { get; set; }
        public string VerificationType { get; set; }
        public int? VerificationUserId { get; set; }
        public DateTime? VerificationTime { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string RefuseReason { get; set; }
    }
}
