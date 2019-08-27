using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TtransportBatch
    {
        public string BatchId { get; set; }
        public int DriverId { get; set; }
        public int TruckId { get; set; }
        public string DistributeCenterId { get; set; }
        public decimal GoodsAmount { get; set; }
        public decimal CodAmount { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
