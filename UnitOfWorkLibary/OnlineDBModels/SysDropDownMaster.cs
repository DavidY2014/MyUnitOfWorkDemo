using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysDropDownMaster
    {
        public int SysNo { get; set; }
        public string Ddtag { get; set; }
        public string Ddname { get; set; }
        public string Dddescribe { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
    }
}
