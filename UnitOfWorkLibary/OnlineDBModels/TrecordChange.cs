using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TrecordChange
    {
        public int ChangeId { get; set; }
        public string TableName { get; set; }
        public string KeyValue { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
