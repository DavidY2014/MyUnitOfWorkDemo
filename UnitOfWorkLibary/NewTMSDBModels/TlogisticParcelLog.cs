using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TlogisticParcelLog
    {
        public long LogId { get; set; }
        public int ParcelId { get; set; }
        public string LogType { get; set; }
        public DateTime LogTime { get; set; }
        public string LogContent { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public byte[] Tmstamp { get; set; }
    }
}
