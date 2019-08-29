using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxWsiteModulebase
    {
        public int Id { get; set; }
        public string MName { get; set; }
        public string MCode { get; set; }
        public int? MValueInt { get; set; }
        public string MValue { get; set; }
        public string MType { get; set; }
        public string MTypeName { get; set; }
        public string PicUrl { get; set; }
        public string Remark { get; set; }
        public int? Seq { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
