using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxXtUser
    {
        public int Id { get; set; }
        public int? BId { get; set; }
        public string Openid { get; set; }
        public string UName { get; set; }
        public string Phone { get; set; }
        public int? PNum { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
