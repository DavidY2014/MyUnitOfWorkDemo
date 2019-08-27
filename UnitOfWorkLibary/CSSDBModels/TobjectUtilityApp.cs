using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TobjectUtilityApp
    {
        public int ObjectUtilityAppId { get; set; }
        public string ObjectType { get; set; }
        public int ObjectId { get; set; }
        public string AppId { get; set; }
        public string AppType { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
