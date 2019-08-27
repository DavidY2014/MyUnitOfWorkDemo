using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TdeliveryTimeConsume
    {
        public string DistributeCenterId { get; set; }
        public int ProvinceId { get; set; }
        public int DaysArrive { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public int InterfaceId { get; set; }
        public int HoursArrive { get; set; }
    }
}
