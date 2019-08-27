using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SysUserFavoriteLink
    {
        public int SysNo { get; set; }
        public int UserSysNo { get; set; }
        public string LinkName { get; set; }
        public string LinkAhref { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
