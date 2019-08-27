using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysRequestAccount
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string DepartMent { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public DateTime RequestTime { get; set; }
        public int? Status { get; set; }
        public int SysNo { get; set; }
    }
}
