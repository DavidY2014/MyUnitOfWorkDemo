using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TriggerTemplete
    {
        public int SysNo { get; set; }
        public string TempleteName { get; set; }
        public string QuerySql { get; set; }
        public string ContentSql { get; set; }
        public string ContentResult { get; set; }
        public int? Status { get; set; }
        public string DataSql { get; set; }
    }
}
