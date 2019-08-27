using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TgoodsAttributeClassRepl
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public short ClassLevel { get; set; }
        public string IsLastLevel { get; set; }
        public int ParentId { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
