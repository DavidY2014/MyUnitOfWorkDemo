using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Category3ReviewItemTd
    {
        public int? C3sysNo { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Weight { get; set; }
        public int? OrderNum { get; set; }
        public int? Status { get; set; }
        public int SysNo { get; set; }

        public virtual Category3 C3sysNoNavigation { get; set; }
    }
}
