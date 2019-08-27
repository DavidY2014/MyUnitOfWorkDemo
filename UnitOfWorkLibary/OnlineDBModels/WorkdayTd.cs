using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class WorkdayTd
    {
        public int SysNo { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public int? TimeSpan { get; set; }
        public int? Week { get; set; }
        public int? Status { get; set; }
    }
}
