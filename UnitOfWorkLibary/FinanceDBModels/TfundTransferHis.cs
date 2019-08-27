using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.FinanceDBModels
{
    public partial class TfundTransferHis
    {
        public int FundTransferHisId { get; set; }
        public int FundTransferId { get; set; }
        public int FundId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public int CustomerGroupId { get; set; }
        public string CustomerGroupName { get; set; }
        public decimal TransferAmount { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string OperateType { get; set; }
        public string TransferSource { get; set; }
    }
}
