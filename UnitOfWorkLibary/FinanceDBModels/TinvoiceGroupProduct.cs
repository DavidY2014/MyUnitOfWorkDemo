using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceGroupProduct
    {
        public int InvoiceGroupProductId { get; set; }
        public int InvoiceGroupId { get; set; }
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductMode { get; set; }
        public string ProductName { get; set; }
        public string ProductUnit { get; set; }
        public decimal Price { get; set; }
        public string TaxCodeCategory { get; set; }
        public decimal TaxRate { get; set; }
        public int Quantity { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Modal { get; set; }
        public string Specification { get; set; }
    }
}
