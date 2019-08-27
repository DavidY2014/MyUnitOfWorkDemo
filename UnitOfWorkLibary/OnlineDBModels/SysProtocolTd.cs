using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysProtocolTd
    {
        public string EventId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ServiceType { get; set; }
        public string BizData { get; set; }
        public int SendType { get; set; }
        public int SendStatus { get; set; }
        public int SysNo { get; set; }
        public string OrderId { get; set; }
    }
}
