using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceGroupDetail
    {
        public int DetailId { get; set; }
        public int InvoiceGroupId { get; set; }
        public int ReferId { get; set; }
        public string ReferCode { get; set; }
        public string ReferType { get; set; }
        public decimal ReferAmt { get; set; }
        public int? DoId { get; set; }
        public string DoCode { get; set; }
        public string SaleOrderCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CostCenterName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
