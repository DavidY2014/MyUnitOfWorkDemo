using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Coupon
    {
        public int SysNo { get; set; }
        public string CouponId { get; set; }
        public string CouponName { get; set; }
        public string CouponCode { get; set; }
        public decimal CouponAmt { get; set; }
        public decimal SaleAmt { get; set; }
        public int CouponType { get; set; }
        public DateTime ValidTimeFrom { get; set; }
        public DateTime ValidTimeTo { get; set; }
        public int MaxUseDegree { get; set; }
        public int UsedDegree { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime CreateTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public DateTime? UsedTime { get; set; }
        public int? BatchNo { get; set; }
        public int Status { get; set; }
        public string CategorySysNoCom { get; set; }
        public string ProductSysNoCom { get; set; }
        public string ManufactorySysNoCom { get; set; }
        public string UseAreaSysNoCom { get; set; }
        public int? UseCustomerSysNo { get; set; }
        public string UseCustomerGradeCom { get; set; }
        public int? IsEmailed { get; set; }
        public int? ChannelType { get; set; }
        public int Type { get; set; }
        public int? CustomerUserCount { get; set; }
        public DateTime? EndTime { get; set; }
        public string CategoryManufactorySysNoCom { get; set; }
        public int SelectCount { get; set; }
        public int IsAddUp { get; set; }
        public string GiftProductSysNoCom { get; set; }
        public string DetailLink { get; set; }
    }
}
