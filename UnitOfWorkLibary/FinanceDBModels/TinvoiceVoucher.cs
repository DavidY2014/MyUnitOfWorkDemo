using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceVoucher
    {
        public int InvoiceVoucherId { get; set; }
        public int InvoiceId { get; set; }
        public int SoId { get; set; }
        public int DoId { get; set; }
        public string InvoiceBusinessType { get; set; }
        public decimal? Amount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public decimal? ShipFee { get; set; }
    }
}
