using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class Ttruck
    {
        public int TruckId { get; set; }
        public string DistributeCenterId { get; set; }
        public string BrandId { get; set; }
        public int DefaultDriverId { get; set; }
        public string PlateNo { get; set; }
        public decimal TrackLength { get; set; }
        public decimal LoadCapacityKg { get; set; }
        public DateTime? DateRegistered { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
