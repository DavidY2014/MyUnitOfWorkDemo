using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TacceptancePayment
    {
        public int AcceptancePaymentId { get; set; }
        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string InvoiceNo { get; set; }
        public string VoucherNo { get; set; }
        public decimal PayAmt { get; set; }
        public DateTime EstimatePayTime { get; set; }
        public DateTime? PaidTime { get; set; }
        public decimal AdvancePaymentAmount { get; set; }
        public decimal PaidInAmount { get; set; }
        public string Note { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public decimal RebateAmount { get; set; }
        public string PayMethod { get; set; }
    }
}
