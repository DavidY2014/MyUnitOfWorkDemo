using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtUserGroupPrice
    {
        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public int? GroupId { get; set; }
        public decimal? Price { get; set; }
    }
}
