using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TitemRelationGroupRepl
    {
        public int GroupId { get; set; }
        public int AttributeId1 { get; set; }
        public int AttributeId2 { get; set; }
        public int AttributeId3 { get; set; }
        public int AttributeId4 { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string IsUseColor { get; set; }
        public string IsUseSpecification { get; set; }
    }
}
