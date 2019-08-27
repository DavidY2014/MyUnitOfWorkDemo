using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ReviewRemarkTd
    {
        public int SysNo { get; set; }
        public int? ReviewSysNo { get; set; }
        public int? IsHelpful { get; set; }
        public int? CreateUserType { get; set; }
        public int? CreateUserSysNo { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ReviewMasterTd ReviewSysNoNavigation { get; set; }
    }
}
