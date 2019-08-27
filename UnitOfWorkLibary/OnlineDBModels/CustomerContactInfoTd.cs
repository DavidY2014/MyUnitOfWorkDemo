using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class CustomerContactInfoTd
    {
        public int SysNo { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhoneNum { get; set; }
        public string Ipaddr { get; set; }
        public int ContactType { get; set; }
        public string Remark { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserSysNo { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
