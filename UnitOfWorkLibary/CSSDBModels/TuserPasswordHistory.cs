using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TuserPasswordHistory
    {
        public int UserPasswordHistoryId { get; set; }
        public int UserId { get; set; }
        public string NewPwd { get; set; }
        public string OldPwd { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
