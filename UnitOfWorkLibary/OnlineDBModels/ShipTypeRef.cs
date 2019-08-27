using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ShipTypeRef
    {
        public int SysNo { get; set; }
        public string ShipTypeId { get; set; }
        public string ShipTypeName { get; set; }
        public string ShipTypeDesc { get; set; }
        public string Period { get; set; }
        public string Provider { get; set; }
        public decimal PremiumRate { get; set; }
        public decimal PremiumBase { get; set; }
        public decimal FreeShipBase { get; set; }
        public string OrderNumber { get; set; }
        public int IsOnlineShow { get; set; }
        public int IsWithPackFee { get; set; }
        public int? StatusQueryType { get; set; }
        public string StatusQueryUrl { get; set; }
        public int IsLarge { get; set; }
        public int ProductSaleType { get; set; }
        public string ShipTypeBk { get; set; }
        public int ExpressGradeService { get; set; }
        public string PickUpAddress { get; set; }
        public int IsSynTms { get; set; }
        public int IsSendInvoice { get; set; }
    }
}
