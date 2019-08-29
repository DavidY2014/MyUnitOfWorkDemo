using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxPaymentType
    {
        public int Id { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public string Remark { get; set; }
        public int? SortId { get; set; }
        public string ImgUrl { get; set; }
        public string ApiPath { get; set; }
    }
}
