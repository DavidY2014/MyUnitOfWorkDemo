using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class TouterParcel
    {
        public int OuterParcelId { get; set; }
        public int CustomerId { get; set; }
        public string OperateType { get; set; }
        public string DistributeCenterId { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string SalesOrderNo { get; set; }
        public string StockOrderNo { get; set; }
        public int PackageCount { get; set; }
        public string Source { get; set; }
        public string Mobile { get; set; }
        public string TelePhone { get; set; }
        public string Company { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CustomerNote { get; set; }
        public int Urgent { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string DeliveryNote { get; set; }
        public string ParcelType { get; set; }
        public string PayType { get; set; }
        public string PayTypeDescription { get; set; }
        public decimal GoodsAmount { get; set; }
        public decimal CodAmount { get; set; }
        public string Remark { get; set; }
        public string IsFailed { get; set; }
        public string FailedReason { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public int Precise { get; set; }
        public int Confidence { get; set; }
        public int AreaId { get; set; }
        public string OrderCustomerId { get; set; }
    }
}
