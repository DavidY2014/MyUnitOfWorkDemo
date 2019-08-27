using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TlogisticLogParcelDetail
    {
        public int DetailId { get; set; }
        public int ParcelId { get; set; }
        public string VoucherNo { get; set; }
        public string CustomerCode { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
