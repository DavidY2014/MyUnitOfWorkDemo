using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TnoticeEventArgument
    {
        public string EventId { get; set; }
        public string ArgumentName { get; set; }
        public short SeqNo { get; set; }
        public string ArgumentDescription { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
