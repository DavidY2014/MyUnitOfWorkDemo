using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class Tdriver
    {
        public int DriverId { get; set; }
        public string DriverCode { get; set; }
        public string DistributeCenterId { get; set; }
        public string DriverName { get; set; }
        public string MobileNo { get; set; }
        public string IdCard { get; set; }
        public DateTime? EntryTime { get; set; }
        public string UrgentContact { get; set; }
        public string UrgentPhone { get; set; }
        public string Address { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
    }
}
