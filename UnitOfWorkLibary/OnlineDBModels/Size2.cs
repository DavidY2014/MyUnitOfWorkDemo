using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Size2
    {
        public int SysNo { get; set; }
        public int? Size1SysNo { get; set; }
        public string Size2Id { get; set; }
        public string Size2Name { get; set; }
        public int? Status { get; set; }
        public string Size2Img { get; set; }

        public virtual Size1 Size1SysNoNavigation { get; set; }
    }
}
