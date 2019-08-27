using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TobjectUtilityApp
    {
        public string ObjectType { get; set; }
        public int ObjectId { get; set; }
        public string AppId { get; set; }
        public string AppType { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
