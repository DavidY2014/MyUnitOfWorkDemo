using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TempUpdateB2bcart
    {
        public long SysNo { get; set; }
        public int OperatorNo { get; set; }
        public string Cart { get; set; }
        public bool Isupdate { get; set; }
    }
}
