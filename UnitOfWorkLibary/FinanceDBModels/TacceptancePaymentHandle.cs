using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TacceptancePaymentHandle
    {
        public int HandleId { get; set; }
        public int AcceptancePaymentId { get; set; }
        public string HandleType { get; set; }
        public string Note { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
