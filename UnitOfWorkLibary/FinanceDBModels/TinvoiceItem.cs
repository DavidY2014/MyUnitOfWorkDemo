using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public int? InvoiceVoucherId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductSkuId { get; set; }
        public string ProductSkuName { get; set; }
        public int InvoiceQuantity { get; set; }
        public string UnitName { get; set; }
        public decimal InvoicePrice { get; set; }
        public decimal Amount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
