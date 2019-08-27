using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TgoodsAttributeValueRepl
    {
        public int AttributeValueId { get; set; }
        public int AttributeId { get; set; }
        public string AttributeValueName { get; set; }
        public int ShowOrder { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
