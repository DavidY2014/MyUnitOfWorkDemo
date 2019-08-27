using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TreplicationType
    {
        public string ReplicationTypeId { get; set; }
        public string ApplicationId { get; set; }
        public string ReplicationTypeName { get; set; }
        public string WriteClassName { get; set; }
        public string PrepareClassName { get; set; }
        public string DataQtyType { get; set; }
        public int BatchQty { get; set; }
        public string IsForceReplicationAll { get; set; }
        public string ReplicationAllWeekDay { get; set; }
        public string ReplicationAllDayTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
