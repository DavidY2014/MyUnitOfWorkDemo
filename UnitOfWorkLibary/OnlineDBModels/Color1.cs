using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Color1
    {
        public Color1()
        {
            Color2 = new HashSet<Color2>();
        }

        public int SysNo { get; set; }
        public string Color1Id { get; set; }
        public string Color1Name { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Color2> Color2 { get; set; }
    }
}
