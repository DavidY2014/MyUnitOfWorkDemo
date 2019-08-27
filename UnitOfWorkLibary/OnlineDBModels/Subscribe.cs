using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Subscribe
    {
        public int SysNo { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
