using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TsiteReplication
    {
        public string ReplicationTypeId { get; set; }
        public DateTime? ReplicationAllLastTime { get; set; }
        public int ReplicationMaxId { get; set; }
        public DateTime? ReplicationLastTime { get; set; }
        public int PrepareMaxId { get; set; }
        public DateTime? PrepareLastTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
