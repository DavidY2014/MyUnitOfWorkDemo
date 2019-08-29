using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardNotice
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string NName { get; set; }
        public string NContent { get; set; }
        public string UserDegree { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SId { get; set; }
    }
}
