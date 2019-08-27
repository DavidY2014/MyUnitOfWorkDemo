using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdvisoryArticleTd
    {
        public int SysNo { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? OrderNum { get; set; }
        public int? Status { get; set; }
        public string ChannelType { get; set; }
        public int? AdvisoryType { get; set; }
        public string Url { get; set; }
        public string BrandName { get; set; }
        public string C2sysNo { get; set; }
        public string C1sysNo { get; set; }
        public string Tag { get; set; }
        public string ShowContent { get; set; }
    }
}
