using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxYyResult
    {
        public int Id { get; set; }
        public int? FormId { get; set; }
        public string Openid { get; set; }
        public string CName { get; set; }
        public int? CId { get; set; }
        public string UserResult { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
