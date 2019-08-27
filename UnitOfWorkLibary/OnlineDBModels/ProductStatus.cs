using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ProductStatus
    {
        public int SysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int InfoStatus { get; set; }
        public int? InfoUserSysNo { get; set; }
        public DateTime? InfoTime { get; set; }
        public int PicStatus { get; set; }
        public int? PicUserSysNo { get; set; }
        public DateTime? PicTime { get; set; }
        public int WarrantyStatus { get; set; }
        public int? WarrantyUserSysNo { get; set; }
        public DateTime? WarrantyTime { get; set; }
        public int PriceStatus { get; set; }
        public int? PriceUserSysNo { get; set; }
        public DateTime? PriceTime { get; set; }
        public int WeightStatus { get; set; }
        public int? WeightUserSysNo { get; set; }
        public DateTime? WeightTime { get; set; }
        public int AllowStatus { get; set; }
        public int? AllowUserSysNo { get; set; }
        public DateTime? AllowTime { get; set; }
        public int? PreviewStatus { get; set; }
        public int? PreviewUserSysNo { get; set; }
        public DateTime? PreviewTime { get; set; }
        public int? Rmastatus { get; set; }
        public int? RmauserSysNo { get; set; }
        public DateTime? Rmatime { get; set; }

        public virtual Product ProductSysNoNavigation { get; set; }
    }
}
