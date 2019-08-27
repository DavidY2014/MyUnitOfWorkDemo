using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class QaTd
    {
        public int SysNo { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string SearchKey { get; set; }
        public int? Type { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? ViewCount { get; set; }
        public int? OrderNum { get; set; }
        public int? Status { get; set; }
    }
}
