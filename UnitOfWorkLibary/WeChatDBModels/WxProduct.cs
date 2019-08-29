using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxProduct
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string HdName { get; set; }
        public string PSubject { get; set; }
        public int? TypeId { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Addr { get; set; }
        public string PContent { get; set; }
        public int? MinPersonNum { get; set; }
        public int? MaxPersonNum { get; set; }
        public string PersonContent { get; set; }
        public bool? IsOpen { get; set; }
        public string CreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Url { get; set; }
        public string UrlName { get; set; }
        public string BtnName { get; set; }
        public double? Price { get; set; }
        public bool? ShowPrice { get; set; }
        public bool? ShowYuDing { get; set; }
        public bool? ShowDate { get; set; }
        public int? ExtInt { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public string ExtStr3 { get; set; }
        public string Tel { get; set; }
        public string Daohangurl { get; set; }
    }
}
