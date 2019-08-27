using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class SaleCountdownNewTd
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Cdprice { get; set; }
        public int Cdqty { get; set; }
        public string CustomerRankCom { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? InterruptTime { get; set; }
        public int? InterruptUserSysNo { get; set; }
        public DateTime? ResumeTime { get; set; }
        public int? ResumeUserSysNo { get; set; }
        public DateTime? CloseTime { get; set; }
        public int SaleQty { get; set; }
        public int BasicNum { get; set; }
        public int? CountDownType { get; set; }
        public string CountDownDescription { get; set; }
        public int? IsEmailNotice { get; set; }
        public int? IsMessageboxNotice { get; set; }
        public int? LimitNum { get; set; }
        public int? SaleQtyCount { get; set; }
        public int ChanelType { get; set; }
        public int OrderNumber { get; set; }
    }
}
