using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUserGroup
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string Groupname { get; set; }
        public string Classname { get; set; }
        public string Gid { get; set; }
        public string ExStr { get; set; }
    }
}
