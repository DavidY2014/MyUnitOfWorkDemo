using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.TestDBModels
{
    public partial class UserLogin
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public string UserName { get; set; }
        public string LoginName { get; set; }
        public string LoginPwd { get; set; }
        public int? RoleId { get; set; }
        public string Telephone { get; set; }
    }
}
