using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class Treconciliation
    {
        public int ReconciliationId { get; set; }
        public int CustomerId { get; set; }
        public int BranchId { get; set; }
        public int CustomerReconciliationId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public string IsGeneratedFile { get; set; }
        public string IsSentMail { get; set; }
        public int SendFailCount { get; set; }
        public string FileName { get; set; }
        public string ErrorMsg { get; set; }
        public DateTime GenerateStartTime { get; set; }
        public int CreateMonth { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public DateTime GenerateEndTime { get; set; }
        public string IsNeedMerge { get; set; }
    }
}
