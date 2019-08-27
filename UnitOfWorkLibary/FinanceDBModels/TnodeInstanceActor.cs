using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TnodeInstanceActor
    {
        public int InstanceActorId { get; set; }
        public int NodeInstanceId { get; set; }
        public string ActorType { get; set; }
        public int Actor { get; set; }
        public string ActType { get; set; }
        public int AllocationUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
