using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSmallLink
    {
        public int Id { get; set; }
        public string SName { get; set; }
        public string Url { get; set; }
        public string SType { get; set; }
        public int? SortId { get; set; }
        public bool? IsGlobal { get; set; }
        public string CompanyName { get; set; }
        public string ComTel { get; set; }
        public string Remark { get; set; }
    }
}
