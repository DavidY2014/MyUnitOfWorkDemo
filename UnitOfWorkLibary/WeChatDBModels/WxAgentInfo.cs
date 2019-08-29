using System;
using System.Collections.Generic;

namespace UnitOfWorkLibary.WeChatDBModels
{
    public partial class WxAgentInfo
    {
        public int Id { get; set; }
        public int? ManagerId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyInfo { get; set; }
        public int? AgentPrice { get; set; }
        public int? AgentPrice2 { get; set; }
        public int? SqJine { get; set; }
        public int? CzTotMoney { get; set; }
        public int? RemainMony { get; set; }
        public int? UserNum { get; set; }
        public int? WcodeNum { get; set; }
        public int? AgentType { get; set; }
        public string AgentLevel { get; set; }
        public string Industry { get; set; }
        public string AgentArea { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string ARemark { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
