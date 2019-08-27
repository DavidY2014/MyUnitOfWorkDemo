using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ReviewReplyTd
    {
        public int SysNo { get; set; }
        public int? ReviewSysNo { get; set; }
        public string ReplyContent { get; set; }
        public int? Status { get; set; }
        public int? CreateUserType { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LastEditUserSysNo { get; set; }
        public DateTime? LastEditDate { get; set; }
        public int? QuoteSysNo { get; set; }
        public int? OperatorSysNo { get; set; }

        public virtual ReviewMasterTd ReviewSysNoNavigation { get; set; }
    }
}
