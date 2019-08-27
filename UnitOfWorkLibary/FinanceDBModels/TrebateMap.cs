using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TrebateMap
    {
        public int AdvancePaymentMapId { get; set; }
        public int? AcceptancePaymentId { get; set; }
        public int RebateId { get; set; }
        public decimal Amount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
