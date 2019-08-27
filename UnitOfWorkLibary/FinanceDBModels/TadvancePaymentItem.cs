using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TadvancePaymentItem
    {
        public int AdvancePaymentItemId { get; set; }
        public int AdvancePaymentId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public int PurchaseQty { get; set; }
        public string SaleUnit { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
