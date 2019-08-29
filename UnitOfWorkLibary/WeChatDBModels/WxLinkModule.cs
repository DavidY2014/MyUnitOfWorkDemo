using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxLinkModule
    {
        public int Id { get; set; }
        public string LName { get; set; }
        public string ModuleName { get; set; }
        public string ModuleCode { get; set; }
        public int? ModuleType { get; set; }
        public string UrlRule { get; set; }
        public bool? UrlNeedReplace { get; set; }
        public string TableName { get; set; }
        public bool? IsGlobal { get; set; }
        public bool? IsMore { get; set; }
        public int? SortId { get; set; }
        public string Remark { get; set; }
        public string IdColumn { get; set; }
        public string NameColumn { get; set; }
    }
}
