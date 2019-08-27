using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class PurchasePlanTd
    {
        public int SysNo { get; set; }
        public int FirstSaleDay { get; set; }
        public decimal FirstSaleRate { get; set; }
        public int SecondSaleDay { get; set; }
        public decimal GrowthRate { get; set; }
        public int PurchaseRecordDay { get; set; }
        public int PurchaseCount { get; set; }
        public int MiddleValue { get; set; }
        public decimal OrderRate { get; set; }
        public int? LastSaleDay { get; set; }
        public decimal? SecondSaleRate { get; set; }
        public int ThirdSaleDay { get; set; }
        public decimal ThirdSaleRate { get; set; }
    }
}
