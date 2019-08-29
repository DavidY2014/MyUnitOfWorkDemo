using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class DtOrderGoods
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? GoodsId { get; set; }
        public string GoodsTitle { get; set; }
        public decimal? GoodsPrice { get; set; }
        public decimal? RealPrice { get; set; }
        public int? Quantity { get; set; }
        public int? Point { get; set; }

        public virtual DtOrders Order { get; set; }
    }
}
