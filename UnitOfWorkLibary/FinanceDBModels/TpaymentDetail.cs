using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TpaymentDetail
    {
        public int PaymentDetailId { get; set; }
        public int? PaymentId { get; set; }
        public string PayAmount { get; set; }
        public string PayStatus { get; set; }
        public string PayResultStatus { get; set; }
        public string PayResultMsg { get; set; }
        public string Remark { get; set; }
        public string RequestMessage { get; set; }
        public string ResponesMessage { get; set; }
        public DateTime? LastTime { get; set; }
        public int? RequestTimes { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
