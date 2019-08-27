using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerStrategyTd
    {
        public long SysNo { get; set; }
        public string CustomerName { get; set; }
        public string LoginStrategy { get; set; }
        public string SoStrategy { get; set; }
        public string SysParameters { get; set; }
        public string Creator { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Editor { get; set; }
        public DateTime? EditTime { get; set; }
        public string PunchOutType { get; set; }
        public string Anid { get; set; }
        public string UnSpsc { get; set; }
        public string Company { get; set; }
        public int? DecimalCount { get; set; }
        public string EnableTaxRate { get; set; }
        public string CheckPower { get; set; }
    }
}
