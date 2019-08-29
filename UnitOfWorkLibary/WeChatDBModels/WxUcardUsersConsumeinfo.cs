using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxUcardUsersConsumeinfo
    {
        public int Id { get; set; }
        public int? SId { get; set; }
        public int? Uid { get; set; }
        public string ModuleType { get; set; }
        public int? ModuleTypeId { get; set; }
        public string ModuleActionName { get; set; }
        public int? ModuleActionId { get; set; }
        public int? CScoreType { get; set; }
        public int? Score { get; set; }
        public int? CMoneyType { get; set; }
        public double? ConsumeMoney { get; set; }
        public string CContent { get; set; }
        public string Remark { get; set; }
        public DateTime? AddTime { get; set; }
        public int? SortId { get; set; }
        public string Sn { get; set; }
        public string OperName { get; set; }
        public string Pwd { get; set; }
    }
}
