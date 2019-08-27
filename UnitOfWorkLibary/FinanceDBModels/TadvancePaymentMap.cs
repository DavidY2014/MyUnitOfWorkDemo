using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TadvancePaymentMap
    {
        public int AdvancePaymentMapId { get; set; }
        public int AdvancePaymentId { get; set; }
        public int AcceptancePaymentId { get; set; }
        public decimal Amount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
