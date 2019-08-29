using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxSmsInfo
    {
        public int Id { get; set; }
        public int Wid { get; set; }
        public string Tel { get; set; }
        public string SmsContent { get; set; }
        public string SStatusNum { get; set; }
        public string SStatus { get; set; }
        public string ModuleName { get; set; }
        public int? ActionId { get; set; }
        public string ActionName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Remark { get; set; }
    }
}
