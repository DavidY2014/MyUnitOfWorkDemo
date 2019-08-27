using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceFund
    {
        public int InvoiceFundId { get; set; }
        public int FundId { get; set; }
        public int InvoiceGroupId { get; set; }
        public string InvoiceNo { get; set; }
        public string Status { get; set; }
        public decimal InvoiceAmount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
