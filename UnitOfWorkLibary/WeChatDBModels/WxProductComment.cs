using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxProductComment
    {
        public int Id { get; set; }
        public int? HdId { get; set; }
        public string OpenId { get; set; }
        public string CommentContent { get; set; }
        public int? CommentType { get; set; }
        public string CommentRemark { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ReplyStatus { get; set; }
        public string ReplyPerson { get; set; }
        public string ReplyContent { get; set; }
        public DateTime? ReplyDate { get; set; }
    }
}
