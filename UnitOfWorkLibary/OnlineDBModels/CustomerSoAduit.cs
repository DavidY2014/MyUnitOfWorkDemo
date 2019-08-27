using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerSoAduit
    {
        public int SysNo { get; set; }
        public int SoSysNo { get; set; }
        public int AduitOpteratorSysNo { get; set; }
        public DateTime AduitDatetime { get; set; }
        public int IsAuitSuccess { get; set; }
        public int? CustomerDepartmentSysNo { get; set; }
        public string Memo { get; set; }
    }
}
