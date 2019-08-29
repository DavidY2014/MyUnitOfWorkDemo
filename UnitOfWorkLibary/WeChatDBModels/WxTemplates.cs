using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxTemplates
    {
        public int Id { get; set; }
        public string TName { get; set; }
        public string Author { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Version { get; set; }
        public string ForWxVersion { get; set; }
        public string TypeName { get; set; }
        public int? TypeId { get; set; }
        public string AboutPic { get; set; }
        public string TFileName { get; set; }
        public string DegreeName { get; set; }
        public int? DegreId { get; set; }
        public string Remark { get; set; }
    }
}
