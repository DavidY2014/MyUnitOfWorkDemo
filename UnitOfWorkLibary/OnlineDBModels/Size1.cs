using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Size1
    {
        public Size1()
        {
            Size2 = new HashSet<Size2>();
        }

        public int SysNo { get; set; }
        public string Size1Id { get; set; }
        public string Size1Name { get; set; }
        public int? Status { get; set; }
        public string Size1Type { get; set; }

        public virtual ICollection<Size2> Size2 { get; set; }
    }
}
