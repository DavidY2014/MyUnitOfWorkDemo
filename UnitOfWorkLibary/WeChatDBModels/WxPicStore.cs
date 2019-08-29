using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxPicStore
    {
        public int Id { get; set; }
        public string PicName { get; set; }
        public string PicUri { get; set; }
        public string PicTemplates { get; set; }
        public int? PicType { get; set; }
        public string PicUsedType { get; set; }
        public string PicValue { get; set; }
        public string PicCreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
