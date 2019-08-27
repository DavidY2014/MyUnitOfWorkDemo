using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ToperationChange
    {
        public int OperationId { get; set; }
        public string TableName { get; set; }
        public string TableKey { get; set; }
        public string OperateType { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
