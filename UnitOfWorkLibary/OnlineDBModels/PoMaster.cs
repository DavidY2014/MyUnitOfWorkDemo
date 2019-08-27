using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class PoMaster
    {
        public PoMaster()
        {
            PoItem = new HashSet<PoItem>();
        }

        public int SysNo { get; set; }
        public string Poid { get; set; }
        public int VendorSysNo { get; set; }
        public int StockSysNo { get; set; }
        public int PayTypeSysNo { get; set; }
        public int CurrencySysNo { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal TotalAmt { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? AuditTime { get; set; }
        public int? AuditUserSysNo { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public int? ReceiveUserSysNo { get; set; }
        public DateTime? InTime { get; set; }
        public int? InUserSysNo { get; set; }
        public int IsApportion { get; set; }
        public DateTime? ApportionTime { get; set; }
        public int? ApportionUserSysNo { get; set; }
        public DateTime? PayDate { get; set; }
        public string Memo { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public int? Potype { get; set; }
        public int? PoinvoiceType { get; set; }
        public string ManagerAuditMemo { get; set; }
        public int? ManagerAuditStatus { get; set; }
        public string PoinvoiceDunDesc { get; set; }
        public DateTime? InvoiceExpectReceiveDate { get; set; }
        public int? ShelveUserSysNo { get; set; }
        public DateTime? ShelveTime { get; set; }
        public int? MinusPotype { get; set; }
        public int? PoshipTypeSysNo { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? CustomerSysNo { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public string ContractNumber { get; set; }
        public string ContractUrl { get; set; }
        public int ReceiveStatus { get; set; }
        public int ProductSaleType { get; set; }
        public string ExportList { get; set; }
        public string PoSourceId { get; set; }
        public int? Positive { get; set; }
        public int? ShipTypeSysNo { get; set; }
        public int SyncStatus { get; set; }
        public int? PurchaseManSysNo { get; set; }
        public int? OrderManSysNo { get; set; }
        public int IsPrepay { get; set; }
        public int PurchaseType { get; set; }
        public int ReferSysNo { get; set; }
        public string ReceiverUserName { get; set; }
        public string ReceiverTelPhone { get; set; }
        public string ReceiverAddress { get; set; }
        public int? CarrierSysNo { get; set; }
        public string VendorDeliveryStatus { get; set; }
        public string VendorHandleStatus { get; set; }

        public virtual ICollection<PoItem> PoItem { get; set; }
    }
}
