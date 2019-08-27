using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TdelayParcel
    {
        public int BatchParcelId { get; set; }
        public int BatchId { get; set; }
        public int ParcelId { get; set; }
        public string ReasonId { get; set; }
        public DateTime DelayTime { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
