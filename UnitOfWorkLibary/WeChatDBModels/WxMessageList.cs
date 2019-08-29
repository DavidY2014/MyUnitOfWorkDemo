using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxMessageList
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }
        public string OpenId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SortId { get; set; }
        public bool? HasSh { get; set; }
    }
}
