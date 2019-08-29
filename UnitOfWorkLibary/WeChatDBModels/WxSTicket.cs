using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSTicket
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string ActionName { get; set; }
        public string SuccTip { get; set; }
        public string Brief { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string AContent { get; set; }
        public string UsedRemark { get; set; }
        public string Telphone { get; set; }
        public string WUrl { get; set; }
        public int? Seq { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string EndNotice { get; set; }
        public string EndContent { get; set; }
        public string BannerPic { get; set; }
        public string BeginPic { get; set; }
        public string EndPic { get; set; }
        public string Pwd { get; set; }
    }
}
