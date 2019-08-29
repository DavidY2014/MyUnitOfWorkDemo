using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardUdegree
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public int? DegreeNum { get; set; }
        public string CallName { get; set; }
        public int? ScoreMin { get; set; }
        public int? ScoreMax { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? SId { get; set; }
    }
}
