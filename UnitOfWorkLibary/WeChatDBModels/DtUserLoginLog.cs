using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtUserLoginLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Remark { get; set; }
        public DateTime? LoginTime { get; set; }
        public string LoginIp { get; set; }

        public virtual DtUsers User { get; set; }
    }
}
