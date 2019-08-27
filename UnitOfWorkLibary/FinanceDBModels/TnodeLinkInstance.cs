using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TnodeLinkInstance
    {
        public int LinkInstanceId { get; set; }
        public int PriorNodeInstanceId { get; set; }
        public int LinkId { get; set; }
        public int NextNodeInstanceId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
