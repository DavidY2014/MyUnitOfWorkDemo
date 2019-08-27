using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TconsumptionExpand
    {
        public int ConsumptionId { get; set; }
        public int CustomerId { get; set; }
        public int AvailablePoints { get; set; }
        public DateTime? FirstOrderTime { get; set; }
        public DateTime? LastOrderTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
