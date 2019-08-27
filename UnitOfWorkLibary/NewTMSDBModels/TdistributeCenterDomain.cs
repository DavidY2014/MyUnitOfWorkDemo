using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TdistributeCenterDomain
    {
        public string DistributeCenterId { get; set; }
        public DateTime StartTime { get; set; }
        public int DomainId { get; set; }
        public DateTime? EndTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
