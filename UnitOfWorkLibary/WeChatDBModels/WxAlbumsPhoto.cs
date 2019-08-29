using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxAlbumsPhoto
    {
        public int Id { get; set; }
        public int? AId { get; set; }
        public string PName { get; set; }
        public string PhotoPic { get; set; }
        public string PContent { get; set; }
        public int? Seq { get; set; }
        public bool? IsHidden { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatePerson { get; set; }
    }
}
