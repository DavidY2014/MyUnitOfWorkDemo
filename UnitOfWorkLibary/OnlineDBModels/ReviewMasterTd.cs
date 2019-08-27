using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ReviewMasterTd
    {
        public ReviewMasterTd()
        {
            ReviewRemarkTd = new HashSet<ReviewRemarkTd>();
            ReviewReplyTd = new HashSet<ReviewReplyTd>();
        }

        public int SysNo { get; set; }
        public int? ReviewType { get; set; }
        public string Title { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }
        public int? Score { get; set; }
        public int? OwnedType { get; set; }
        public int? UnderstandingType { get; set; }
        public string NickName { get; set; }
        public int? ReferenceType { get; set; }
        public int? ReferenceSysNo { get; set; }
        public int? IsTop { get; set; }
        public int? IsGood { get; set; }
        public int? TotalRemarkCount { get; set; }
        public int? TotalHelpfulRemarkCount { get; set; }
        public int? TotalComplainCount { get; set; }
        public int? Status { get; set; }
        public int? CreateCustomerSysNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? LastEditUserSysNo { get; set; }
        public DateTime? LastEditDate { get; set; }
        public string CustomerIp { get; set; }
        public int IsaddScore { get; set; }
        public int? Ordersysno { get; set; }
        public int? Browses { get; set; }
        public int? Integral { get; set; }
        public int? OperatorSysNo { get; set; }

        public virtual ICollection<ReviewRemarkTd> ReviewRemarkTd { get; set; }
        public virtual ICollection<ReviewReplyTd> ReviewReplyTd { get; set; }
    }
}
