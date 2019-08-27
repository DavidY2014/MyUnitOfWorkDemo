using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TverificationGroupDetail
    {
        public int DetailId { get; set; }
        public int VerificationGroupId { get; set; }
        public int InvoiceGroupId { get; set; }
        public string ReferType { get; set; }
        public int ReferId { get; set; }
        public string ReferCode { get; set; }
        public decimal ReferAmount { get; set; }
        public decimal VerificationAmount { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public DateTime? OutTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
