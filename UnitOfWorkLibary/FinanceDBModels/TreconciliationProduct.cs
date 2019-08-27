using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TreconciliationProduct
    {
        public int ReconciliationProductId { get; set; }
        public int ReconciliationId { get; set; }
        public int ReconciliationDetailId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductFullName { get; set; }
        public string Category1Name { get; set; }
        public string Category2Name { get; set; }
        public string Category3Name { get; set; }
        public string SaleUnit { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TaxRate { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string ProductName { get; set; }
        public string TaxCodeCategory { get; set; }
    }
}
