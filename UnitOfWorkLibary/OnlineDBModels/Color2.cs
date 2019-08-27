using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Color2
    {
        public int SysNo { get; set; }
        public int? Color1SysNo { get; set; }
        public string Color2Id { get; set; }
        public string Color2Name { get; set; }
        public int? Status { get; set; }
        public string Color2Img { get; set; }

        public virtual Color1 Color1SysNoNavigation { get; set; }
    }
}
