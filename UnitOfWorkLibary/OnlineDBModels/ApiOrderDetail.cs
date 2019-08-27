using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class ApiOrderDetail
    {
        public int SysNo { get; set; }
        public int LineNo { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int OrderQty { get; set; }
        public decimal? OrderPrice { get; set; }
        public string ProductUnit { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateUserSysNo { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateUserSysNo { get; set; }
        public int MasterSysNo { get; set; }
        public int StockSysNo { get; set; }
        public string FromId { get; set; }
        public int? Type { get; set; }
        public string Poid { get; set; }
        public int RepProductSysNo { get; set; }
        public int? C3sysNo { get; set; }
        public string InventoryTurnover { get; set; }
        public string TaxCodeCategory { get; set; }
        public decimal TaxRate { get; set; }
        public string Remark { get; set; }
        public string ItemTag { get; set; }
        public string VendorCode { get; set; }
        public int TransposeUserId { get; set; }
        public DateTime? TransposeTime { get; set; }
    }
}
