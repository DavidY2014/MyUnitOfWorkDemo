using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardPrivileges
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string PName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UsedContent { get; set; }
        public string UserDegree { get; set; }
        public int? SId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SortId { get; set; }
    }
}
