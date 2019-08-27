using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TdataTrack
    {
        public int TrackId { get; set; }
        public string TrackType { get; set; }
        public string RelativeId { get; set; }
        public string AdditiveId { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
