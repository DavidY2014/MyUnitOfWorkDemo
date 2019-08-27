using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceGroupOffice
    {
        public int Id { get; set; }
        public int DoId { get; set; }
        public string DoCode { get; set; }
        public int SoId { get; set; }
        public string SoCode { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceTitle { get; set; }
        public string ElecEmail { get; set; }
        public decimal SoAmt { get; set; }
        public decimal DoAmt { get; set; }
        public int? SaleUserId { get; set; }
        public string SaleUserName { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AuditUserId { get; set; }
        public int? CancelUserId { get; set; }
        public DateTime? CancelTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
