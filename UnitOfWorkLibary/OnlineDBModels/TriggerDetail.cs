using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class TriggerDetail
    {
        public int SysNo { get; set; }
        public int? TempleteSysNo { get; set; }
        public string DetailName { get; set; }
        public int? SpaceOfTime { get; set; }
        public int? TaskType { get; set; }
        public int? SendType { get; set; }
        public int? ExecType { get; set; }
        public int? DateType { get; set; }
        public int? DateNum { get; set; }
        public string Content { get; set; }
        public string Smscontent { get; set; }
        public int? Status { get; set; }
        public string MailSubject { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CouponBatchNo { get; set; }
        public string TrackingCode { get; set; }
        public string ReceiveEmails { get; set; }
        public string ReceivePhones { get; set; }
        public string Times { get; set; }
    }
}
