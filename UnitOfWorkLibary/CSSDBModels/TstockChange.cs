using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TstockChange
    {
        public int ChangeId { get; set; }
        public int HandleId { get; set; }
        public string Soid { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
