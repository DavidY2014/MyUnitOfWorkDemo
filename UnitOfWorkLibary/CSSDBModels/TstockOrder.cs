using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.CSSDBModels
{
    public partial class TstockOrder
    {
        public string Soid { get; set; }
        public DateTime? OrderDate { get; set; }
        public string StatusCode { get; set; }
        public string StatusValue { get; set; }
        public int? ProductCount { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ReceiveContact { get; set; }
        public string UserName { get; set; }
        public string ReceivePhone { get; set; }
        public string ReceiveCellPhone { get; set; }
        public string SosourceValue { get; set; }
        public string ChannelSoid { get; set; }
        public string DepartmentCompanyName { get; set; }
        public string ReceiveName { get; set; }
        public string SosourceCode { get; set; }
        public string SaleUser { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public string CustomerNote { get; set; }
        public string IsHand { get; set; }
        public string StockSysNo { get; set; }
        public int? CustomerManSysNo { get; set; }
        public int? SaleManSysNo { get; set; }
        public string AccountEmail { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? ReceiveAreaSysNo { get; set; }
        public string ReceiveAddress { get; set; }
    }
}
