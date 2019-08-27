using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysUserOut
    {
        public int Sysno { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? Sex { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
        public int Class { get; set; }
        public string Note { get; set; }
        public DateTime CreateTime { get; set; }
        public int? Creater { get; set; }
        public DateTime? EditTime { get; set; }
        public int? Editer { get; set; }
        public int? SysUserSysNo { get; set; }
    }
}
