using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdvancedFund
    {
        public int SysNo { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ProduceDate { get; set; }
        public int Inserter { get; set; }
        public DateTime? InsertDate { get; set; }
        public short? Status { get; set; }
        public short? IsReconciliation { get; set; }
        public string CustomerId { get; set; }
        public decimal RestAmount { get; set; }
        public decimal InvoiceAmount { get; set; }
        public int? Nature { get; set; }
        public int? ModeOfPayment { get; set; }
        public string Remark { get; set; }
        public string CustomerName { get; set; }
        public string PaymentRemark { get; set; }
    }
}
