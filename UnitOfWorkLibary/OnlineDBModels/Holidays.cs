using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Holidays
    {
        public int SysNo { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
        public int Type { get; set; }
        public string Remark { get; set; }
    }
}
