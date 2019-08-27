using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TgisArea
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int DomainId { get; set; }
        public string IsByRegion { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int DefaultTruckId { get; set; }
        public string DistributeCenterId { get; set; }
        public string Color { get; set; }
        public string Address { get; set; }
        public decimal PointLongitude { get; set; }
        public decimal PointLatitude { get; set; }
        public string Path { get; set; }
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Status { get; set; }
        public string ShippingType { get; set; }
    }
}
