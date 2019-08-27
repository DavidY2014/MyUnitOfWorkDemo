using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CategoryAttribute1Td
    {
        public int C3sysNo { get; set; }
        public string Attribute1Id { get; set; }
        public string Attribute1Name { get; set; }
        public int OrderNum { get; set; }
        public int Status { get; set; }
        public int? Attribute1Type { get; set; }
        public int SysNo { get; set; }

        public virtual Category3 C3sysNoNavigation { get; set; }
    }
}
