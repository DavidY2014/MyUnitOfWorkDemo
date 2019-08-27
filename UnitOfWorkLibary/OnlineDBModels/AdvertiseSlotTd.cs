using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AdvertiseSlotTd
    {
        public int SysNo { get; set; }
        public int AdvertiseType { get; set; }
        public int? Category { get; set; }
        public int? CategoryType { get; set; }
        public string Content { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? AbandonTime { get; set; }
        public int? AbandonUserSysNo { get; set; }
        public int Status { get; set; }
        public int? ShowForums { get; set; }
        public int ProductSaleType { get; set; }
        public int? ManufacturerId { get; set; }
        public string ProductSysNoList { get; set; }
    }
}
