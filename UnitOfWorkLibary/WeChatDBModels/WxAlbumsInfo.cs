using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxAlbumsInfo
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string AName { get; set; }
        public string FacePic { get; set; }
        public string AContent { get; set; }
        public bool? ShowContent { get; set; }
        public bool? IsHidden { get; set; }
        public int? Seq { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatePerson { get; set; }
        public int? TypeId { get; set; }
        public string Music { get; set; }
        public int? ShowType { get; set; }
    }
}
