using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TreconciliationDetail
    {
        public int ReconciliationDetailId { get; set; }
        public int ReconciliationId { get; set; }
        public int BranchId { get; set; }
        public int ReferId { get; set; }
        public string ReferType { get; set; }
        public string ReferCode { get; set; }
        public string SaleOrderCode { get; set; }
        public string PurchaseRequestCode { get; set; }
        public int CostCenterId { get; set; }
        public string CostCenterName { get; set; }
        public DateTime? CostCenterCreateTime { get; set; }
        public int OrdererId { get; set; }
        public string OrdererName { get; set; }
        public DateTime? OrdererCreateTime { get; set; }
        public int ReceiverId { get; set; }
        public string ReceiverName { get; set; }
        public DateTime? ReceiverCreateTime { get; set; }
        public DateTime? SignTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public DateTime? OrderTime { get; set; }
        public string VerificationStatus { get; set; }
        public decimal ReferAmount { get; set; }
        public decimal VerificatedAmount { get; set; }
        public decimal Freight { get; set; }
        public string InvoiceTitle { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
