using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxXtBase
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string WxTitle { get; set; }
        public string Keywords { get; set; }
        public string Fengmian { get; set; }
        public string Donghua { get; set; }
        public string DonghuaSlt { get; set; }
        public string ManName { get; set; }
        public string FelmanName { get; set; }
        public int? NameSeq { get; set; }
        public string Tel { get; set; }
        public DateTime? Statedate { get; set; }
        public string Addr { get; set; }
        public double? LngX { get; set; }
        public double? LatY { get; set; }
        public string Video { get; set; }
        public string Video2 { get; set; }
        public string Music { get; set; }
        public string Word { get; set; }
        public string Sqrurl { get; set; }
        public string Copyrite { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string Pwd { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public int? ExtInt { get; set; }
    }
}
