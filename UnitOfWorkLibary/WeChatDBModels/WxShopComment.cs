using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxShopComment
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Openid { get; set; }
        public string UserName { get; set; }
        public string UserIp { get; set; }
        public string CContent { get; set; }
        public DateTime? AddTime { get; set; }
        public int? IsReply { get; set; }
        public string ReplyContent { get; set; }
        public DateTime? ReplyTime { get; set; }
    }
}
