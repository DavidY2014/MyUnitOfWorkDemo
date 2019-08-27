using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TnodeActor
    {
        public int NodeActorId { get; set; }
        public int NodeId { get; set; }
        public string ActorSource { get; set; }
        public string IsMultiActor { get; set; }
        public string ActorRelationType { get; set; }
        public string ActorRelationValue { get; set; }
        public string ActorType { get; set; }
        public int Actor { get; set; }
        public string ActType { get; set; }
        public string IsIncludeChild { get; set; }
        public string IsIncludePlurality { get; set; }
        public short SeqNo { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
