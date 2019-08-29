using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxPropertyInfo
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public string IName { get; set; }
        public string IContent { get; set; }
        public int? ExpiresIn { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Count { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Remark { get; set; }
    }
}
