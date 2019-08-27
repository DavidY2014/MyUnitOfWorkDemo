using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TgoodsAttributeRepl
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string OuterName { get; set; }
        public string AttributeUnit { get; set; }
        public int ClassId { get; set; }
        public string InputType { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
