using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TinvoiceGroupVersionReceiver
    {
        public int InvoiceGroupVersionId { get; set; }
        public int InvoiceSerialNo { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverMobile { get; set; }
        public string ReceiverAddress { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
