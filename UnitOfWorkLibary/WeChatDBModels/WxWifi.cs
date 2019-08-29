using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxWifi
    {
        public int Id { get; set; }
        public int Wid { get; set; }
        public string Appkey { get; set; }
        public string Secret { get; set; }
        public string MerchantId { get; set; }
        public string ExtStr { get; set; }
        public string ExtSt2 { get; set; }
        public string ExtStr3 { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
