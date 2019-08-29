using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxPurchaseBase
    {
        public int Id { get; set; }
        public string ActivityName { get; set; }
        public string ActivitySummary { get; set; }
        public DateTime? ActivityTimebegin { get; set; }
        public string Email { get; set; }
        public string EmailPwd { get; set; }
        public string Smtp { get; set; }
        public string ShopsPwd { get; set; }
        public string ActiveDescription { get; set; }
        public string SpecialRemind { get; set; }
        public string ActivityEndtitle { get; set; }
        public string EndExplanation { get; set; }
        public string Shopstel { get; set; }
        public string Address { get; set; }
        public string Introduction { get; set; }
        public string GoodName { get; set; }
        public double? CostPrice { get; set; }
        public int? LimitCount { get; set; }
        public double? GroupPrice { get; set; }
        public int? TotalCount { get; set; }
        public int? GroupPerson { get; set; }
        public int? VirtualPerson { get; set; }
        public string CopyrightSetup { get; set; }
        public DateTime? ActivityTimeend { get; set; }
        public DateTime? Createtime { get; set; }
        public int? Wid { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlend { get; set; }
        public double? TxtLatXpoint { get; set; }
        public double? TxtLngYpoint { get; set; }
    }
}
