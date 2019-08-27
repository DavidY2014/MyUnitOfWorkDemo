using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TnodeApplication
    {
        public int NodeId { get; set; }
        public string ApplicationType { get; set; }
        public string ConfigValue1 { get; set; }
        public string ConfigValue2 { get; set; }
        public int ParameterSetId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
