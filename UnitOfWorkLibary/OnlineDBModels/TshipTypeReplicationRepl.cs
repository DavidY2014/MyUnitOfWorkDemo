using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TshipTypeReplicationRepl
    {
        public int ShipTypeId { get; set; }
        public string CommunicationUserId { get; set; }
        public string CommunicationKey { get; set; }
        public string AccessUrl { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
