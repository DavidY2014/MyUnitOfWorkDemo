using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class StockRef
    {
        public int SysNo { get; set; }
        public string StockId { get; set; }
        public string StockName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public int Status { get; set; }
        public int? StockType { get; set; }
        public string Area { get; set; }
        public string StockZip { get; set; }
        public string WarehouseId { get; set; }
        public int IsSendWms { get; set; }
        public string ChannelType { get; set; }
        public int IsAutomaticAudit { get; set; }
    }
}
