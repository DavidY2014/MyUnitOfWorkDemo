using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class AsnItem
    {
        public int SysNo { get; set; }
        public int AsnsysNo { get; set; }
        public int ReferSysNo { get; set; }
        public int ProductSysNo { get; set; }
        public int Asnqty { get; set; }
        public int ReceiveQty { get; set; }
        public string DiffReason { get; set; }
        public decimal? OrderPrice { get; set; }
        public int? Shelveusersysno { get; set; }
        public DateTime? ShelveTime { get; set; }
        public int? ShelveQuantity { get; set; }
        public string StockNo { get; set; }
        public decimal? UnitPoints { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? UnitUsePoints { get; set; }
        public decimal? TotalUsePoints { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int UpdateUserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public decimal VatRate { get; set; }
        public decimal NetCost { get; set; }
    }
}
