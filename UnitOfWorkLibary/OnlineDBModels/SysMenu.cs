using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysMenu
    {
        public int MenuId { get; set; }
        public int ParentId { get; set; }
        public int? OrderNum { get; set; }
        public int? SubOrder { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Href { get; set; }
        public string Help { get; set; }
        public string Icon { get; set; }
        public string Privilege { get; set; }
        public int? Status { get; set; }
        public int SysNo { get; set; }
    }
}
