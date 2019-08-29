using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxYyBase
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string Title { get; set; }
        public string Addr { get; set; }
        public string Phone { get; set; }
        public string KfName { get; set; }
        public string Content { get; set; }
        public string PicUrl { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Remark { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Seq { get; set; }
        public bool? NeedSms { get; set; }
    }
}
