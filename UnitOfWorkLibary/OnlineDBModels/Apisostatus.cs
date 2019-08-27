using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class Apisostatus
    {
        public int SysNo { get; set; }
        public string FromId { get; set; }
        public string ChannelSoid { get; set; }
        public decimal? OrderTotalPrice { get; set; }
        public int? Status { get; set; }
        public int? InvoiceStatus { get; set; }
        public string ProductsDetail { get; set; }
        public string ReturnDetail { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
