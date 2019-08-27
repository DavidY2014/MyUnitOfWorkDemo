using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class PayTypeRef
    {
        public int SysNo { get; set; }
        public string PayTypeId { get; set; }
        public string PayTypeName { get; set; }
        public string PayTypeDesc { get; set; }
        public string Period { get; set; }
        public string PaymentPage { get; set; }
        public decimal PayRate { get; set; }
        public int IsNet { get; set; }
        public int IsPayWhenRecv { get; set; }
        public string OrderNumber { get; set; }
        public int IsOnlineShow { get; set; }
        public int ProductSaleType { get; set; }
        public int IsInvoice { get; set; }
        public int IsAccountPeriod { get; set; }
    }
}
