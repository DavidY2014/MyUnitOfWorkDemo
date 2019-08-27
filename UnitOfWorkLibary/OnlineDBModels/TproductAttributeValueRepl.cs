using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TproductAttributeValueRepl
    {
        public int ProductAttributeValueId { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public int AttributeValueId { get; set; }
        public string AttributeValue { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
