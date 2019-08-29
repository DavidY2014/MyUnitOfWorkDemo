using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUserweixin
    {
        public int Id { get; set; }
        public int? UId { get; set; }
        public string WxName { get; set; }
        public string WxId { get; set; }
        public string YixinId { get; set; }
        public string WeixinCode { get; set; }
        public string WxPwd { get; set; }
        public string Headerpic { get; set; }
        public string Apiurl { get; set; }
        public string WxToken { get; set; }
        public string WxProvince { get; set; }
        public string WxCity { get; set; }
        public string AppId { get; set; }
        public string AppSecret { get; set; }
        public string AccessToken { get; set; }
        public string OpenIdStr { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? WenziMaxNum { get; set; }
        public int? TuwenMaxNum { get; set; }
        public int? YuyinMaxNum { get; set; }
        public int? WenziDefineNum { get; set; }
        public int? TuwenDefineNum { get; set; }
        public int? YuyinDefineNum { get; set; }
        public int? RequestTtnum { get; set; }
        public int? RequestUsedNum { get; set; }
        public int? SmsTtnum { get; set; }
        public int? SmsUsedNum { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? WxType { get; set; }
        public string Remark { get; set; }
        public int? Seq { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public string ExtStr3 { get; set; }
        public int? ExtInt { get; set; }
        public int? ExtInt2 { get; set; }
    }
}
