using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.OnlineDBModels
{
    public partial class RmaRegisterTd
    {
        public int SysNo { get; set; }
        public int? ProductSysNo { get; set; }
        public int? RequestType { get; set; }
        public string CustomerDesc { get; set; }
        public DateTime? CheckTime { get; set; }
        public string CheckDesc { get; set; }
        public int? NewProductStatus { get; set; }
        public int? RevertStatus { get; set; }
        public int? OutBoundStatus { get; set; }
        public int? ReturnStatus { get; set; }
        public string ResponseDesc { get; set; }
        public DateTime? ResponseTime { get; set; }
        public int? RefundStatus { get; set; }
        public int? NextHandler { get; set; }
        public string Memo { get; set; }
        public int? Status { get; set; }
        public string ProductNo { get; set; }
        public int? ProductIdsysNo { get; set; }
        public int? NewProductIdsysNo { get; set; }
        public int? IsWithin7Days { get; set; }
        public int? IsRecommendRefund { get; set; }
        public string RefundInfo { get; set; }
        public int? OwnBy { get; set; }
        public int? Location { get; set; }
        public decimal? Cost { get; set; }
        public int? Rmareason { get; set; }
        public int? CheckUserSysNo { get; set; }
        public int? ResponseUserSysNo { get; set; }
        public int? CloseUserSysNo { get; set; }
        public DateTime? CloseTime { get; set; }
        public int? RevertAuditUserSysNo { get; set; }
        public DateTime? RevertAuditTime { get; set; }
        public int? RevertAuditMemo { get; set; }
        public int? RevertProductSysNo { get; set; }
        public int? RefundAuditUserSysNo { get; set; }
        public string RefundAuditMemo { get; set; }
        public DateTime? RefundAuditTime { get; set; }
        public int? IsHaveInvoice { get; set; }
        public int? IsFullAccessory { get; set; }
        public int? IsFullPackage { get; set; }
        public int? ReceiveStockSysNo { get; set; }
        public string AttachmentInfo { get; set; }
        public string InspectionResultType { get; set; }
        public string VendorRepairResultType { get; set; }
        public int? OutBoundWithInvoice { get; set; }
        public string ResponseProductNo { get; set; }
        public int? RevertStockSysNo { get; set; }
        public string PmdunDesc { get; set; }
        public DateTime? PmdunTime { get; set; }
        public int? IsContactCustomer { get; set; }
        public int? RegisterReceiveType { get; set; }
        public int? ShiftStatus { get; set; }
        public int? SetShiftUserSysNo { get; set; }
        public DateTime? SetShiftTime { get; set; }
        public int? CheckRepairResult { get; set; }
        public string CheckRepairNote { get; set; }
        public int? CheckRepairUserSysNo { get; set; }
        public DateTime? CheckRepairTime { get; set; }
        public int? HandoverStatus { get; set; }
    }
}
