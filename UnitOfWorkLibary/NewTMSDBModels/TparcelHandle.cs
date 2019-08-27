using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TparcelHandle
    {
        public int HandleId { get; set; }
        public int ParcelId { get; set; }
        public string ReasonId { get; set; }
        public string HandleType { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
