using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxVoteBase
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string Title { get; set; }
        public string Votepic { get; set; }
        public bool? Picdisplay { get; set; }
        public string Votecontent { get; set; }
        public bool? IsRadio { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ResultShowtype { get; set; }
        public string ActUrl { get; set; }
        public int? VoteType { get; set; }
        public int? SortId { get; set; }
        public DateTime? CreatDate { get; set; }
    }
}
