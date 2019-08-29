using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxManagerBill
    {
        public int Id { get; set; }
        public int? ManagerId { get; set; }
        public string MoneyType { get; set; }
        public int? BillMoney { get; set; }
        public string BillUsed { get; set; }
        public int? OperPersonId { get; set; }
        public DateTime? OperDate { get; set; }
        public string Remark { get; set; }
    }
}
