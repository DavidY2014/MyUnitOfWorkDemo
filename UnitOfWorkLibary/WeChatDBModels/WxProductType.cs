using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxProductType
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public int? ParentId { get; set; }
        public string TCode { get; set; }
        public string TName { get; set; }
        public string TUrl { get; set; }
        public int? ClassLayer { get; set; }
        public string Remark { get; set; }
        public string IcoPic { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreatDate { get; set; }
        public string ExtStr { get; set; }
        public string ExtStr2 { get; set; }
        public int? StoreId { get; set; }
        public string Tel { get; set; }
        public string Daohangurl { get; set; }
        public bool? ShowDefault { get; set; }
    }
}
