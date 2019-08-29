using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxPurchaseCustomer
    {
        public int Id { get; set; }
        public int? Baseid { get; set; }
        public string Sn { get; set; }
        public string CustomerName { get; set; }
        public int? CustomerNum { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public int? Status { get; set; }
        public DateTime? DateJoin { get; set; }
        public DateTime? DateUse { get; set; }
        public DateTime? CraeteTime { get; set; }
        public string Openid { get; set; }
        public string Remark { get; set; }
    }
}
