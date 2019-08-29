using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxPaymentAlipay
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string OwnerName { get; set; }
        public string Partner { get; set; }
        public string EKey { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public string SignType { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
    }
}
