using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxYyyUsersTemp
    {
        public int Id { get; set; }
        public int? ActId { get; set; }
        public string Openid { get; set; }
        public int? Times { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
