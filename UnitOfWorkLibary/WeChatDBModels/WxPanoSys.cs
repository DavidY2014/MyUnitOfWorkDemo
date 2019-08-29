using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxPanoSys
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string BackPic { get; set; }
        public int? SeriesId { get; set; }
        public string SeriesName { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Seq { get; set; }
    }
}
