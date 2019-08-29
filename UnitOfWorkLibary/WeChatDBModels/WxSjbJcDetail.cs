using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSjbJcDetail
    {
        public int Id { get; set; }
        public int? Uid { get; set; }
        public int? RcId { get; set; }
        public int? BsId { get; set; }
        public int? JcRetType { get; set; }
        public bool? RetIsRight { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
