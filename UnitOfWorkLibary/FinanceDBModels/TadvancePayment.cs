using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TadvancePayment
    {
        public int AdvancePaymentId { get; set; }
        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public decimal AdvanceAmt { get; set; }
        public decimal VerifyAmt { get; set; }
        public string VerifyStatus { get; set; }
        public string ReferType { get; set; }
        public int ReferId { get; set; }
        public DateTime? PaidTime { get; set; }
        public string Note { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
