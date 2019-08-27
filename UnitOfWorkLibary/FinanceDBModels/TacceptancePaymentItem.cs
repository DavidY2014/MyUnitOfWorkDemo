using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TacceptancePaymentItem
    {
        public int AcceptancePaymentItemId { get; set; }
        public int AcceptancePaymentId { get; set; }
        public int AccountsPayableId { get; set; }
        public decimal PopayAmt { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
