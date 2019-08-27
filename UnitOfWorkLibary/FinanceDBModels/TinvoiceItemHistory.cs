using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceItemHistory
    {
        public int HistoryId { get; set; }
        public int InvoiceItemId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductSkuId { get; set; }
        public string ProductSkuName { get; set; }
        public int InvoiceQuantity { get; set; }
        public decimal InvoicePrice { get; set; }
        public decimal Amount { get; set; }
    }
}
