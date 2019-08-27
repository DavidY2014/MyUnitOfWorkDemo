using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class EnterpriseType
    {
        public int SysNo { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int? Level { get; set; }
    }
}
