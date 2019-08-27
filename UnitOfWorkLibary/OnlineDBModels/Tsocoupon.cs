using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Tsocoupon
    {
        public int SocouponId { get; set; }
        public int SoSysNo { get; set; }
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public string CouponType { get; set; }
        public int CouponBatchId { get; set; }
        public string CouponBatchType { get; set; }
        public string CouponBatchName { get; set; }
        public decimal UseCouponThreshold { get; set; }
        public decimal CouponAmt { get; set; }
        public DateTime CouponEndTime { get; set; }
        public int GiftedItemSkuId { get; set; }
        public string GiftedItemSkuName { get; set; }
        public int GiftedItemSkuQuantity { get; set; }
        public decimal GiftedItemSkuPrice { get; set; }
        public string IsDiscontinue { get; set; }
        public string IsCloseOut { get; set; }
        public int GiftedSaleableQty { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public int UpdateUserId { get; set; }
        public string Status { get; set; }
    }
}
