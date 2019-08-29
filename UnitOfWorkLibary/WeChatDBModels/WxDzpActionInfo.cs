using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxDzpActionInfo
    {
        public int Id { get; set; }
        public int? Wid { get; set; }
        public string ActName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Brief { get; set; }
        public string ContractInfo { get; set; }
        public string ActContent { get; set; }
        public string Cfcjhf { get; set; }
        public string EndNotice { get; set; }
        public string EndContent { get; set; }
        public int? PersonNum { get; set; }
        public int? PersonMaxTimes { get; set; }
        public int? DayMaxTimes { get; set; }
        public string OpenXyj { get; set; }
        public DateTime? CreateDate { get; set; }
        public string BeginPic { get; set; }
        public string EndPic { get; set; }
        public int? AStatus { get; set; }
        public string DjPwd { get; set; }
    }
}
