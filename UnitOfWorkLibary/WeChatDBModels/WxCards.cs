using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxCards
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string Openid { get; set; }
        public string Title { get; set; }
        public string BackPic { get; set; }
        public string BackMusic { get; set; }
        public string BackCartoon { get; set; }
        public string Characters { get; set; }
        public string CopyRight { get; set; }
        public string ButtonCharacter { get; set; }
        public bool? Display { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? CkCount { get; set; }
        public int? ZfCount { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
